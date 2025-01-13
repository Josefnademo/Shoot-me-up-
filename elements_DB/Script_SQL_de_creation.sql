-- DB creation if not exists
CREATE DATABASE IF NOT EXISTS jeu_database;
USE jeu_database;

-- Creation of roles
CREATE ROLE IF NOT EXISTS admin_role;
CREATE ROLE IF NOT EXISTS manager_role;
CREATE ROLE IF NOT EXISTS player_role;

-- Assigning privileges to roles
GRANT CREATE, ALTER, SELECT, INSERT, UPDATE, DELETE ON jeu_database.* TO admin_role;
GRANT SELECT, INSERT, UPDATE, DELETE ON jeu_database.* TO manager_role;
GRANT SELECT ON jeu_database.* TO player_role;

-- Creating Users and Assigning Roles

--Creating an administrator user:
CREATE USER IF NOT EXISTS 'admin_user'@'localhost' IDENTIFIED BY 'admin_password';
GRANT admin_role TO 'admin_user'@'localhost';

--Creating a manager user:
CREATE USER IF NOT EXISTS 'manager_user'@'localhost' IDENTIFIED BY 'manager_password';
GRANT manager_role TO 'manager_user'@'localhost';

--Creating a player user:
CREATE USER IF NOT EXISTS 'player_user'@'localhost' IDENTIFIED BY 'player_password';
GRANT player_role TO 'player_user'@'localhost';



-- Creation of tables
CREATE TABLE t_score(
   score_id COUNTER,
   score VARCHAR(50),
   PRIMARY KEY(score_id)
);

CREATE TABLE t_enemy(
   enemy_id COUNTER,
   type_of_enemy VARCHAR(50),
   HP SMALLINT NOT NULL,
   placeY VARCHAR(5),
   placeX VARCHAR(5),
   PRIMARY KEY(enemy_id)
);

CREATE TABLE t_player(
   player_id COUNTER,
   nickname VARCHAR(25) NOT NULL,
   HP INT,
   placeY VARCHAR(5),
   placeX VARCHAR(5),
   score_id INT,
   PRIMARY KEY(player_id),
   FOREIGN KEY(score_id) REFERENCES t_score(score_id)
);

CREATE TABLE t_obstacle(
   obstacle_id COUNTER,
   placeY VARCHAR(5) NOT NULL,
   placeX VARCHAR(5) NOT NULL,
   size VARCHAR(20),
   PRIMARY KEY(obstacle_id)
);

CREATE TABLE t_sounds_music(
   sounds_music_id COUNTER,
   music VARCHAR(200),
   PRIMARY KEY(sounds_music_id)
);

CREATE TABLE t_level(
   level_id COUNTER,
   level_name VARCHAR(50),
   difficulty VARCHAR(50),
   sounds_music_id INT NOT NULL,
   PRIMARY KEY(level_id),
   UNIQUE(level_name),
   FOREIGN KEY(sounds_music_id) REFERENCES t_sounds_music(sounds_music_id)
);

CREATE TABLE t_belongs(
   level_id INT,
   enemy_id INT,
   PRIMARY KEY(level_id, enemy_id),
   FOREIGN KEY(level_id) REFERENCES t_level(level_id),
   FOREIGN KEY(enemy_id) REFERENCES t_enemy(enemy_id)
);

CREATE TABLE t_is_owned(
   score_id INT,
   level_id INT,
   PRIMARY KEY(score_id, level_id),
   FOREIGN KEY(score_id) REFERENCES t_score(score_id),
   FOREIGN KEY(level_id) REFERENCES t_level(level_id)
);

CREATE TABLE t_included(
   level_id INT,
   obstacle_id INT,
   PRIMARY KEY(level_id, obstacle_id),
   FOREIGN KEY(level_id) REFERENCES t_level(level_id),
   FOREIGN KEY(obstacle_id) REFERENCES t_obstacle(obstacle_id)
);

CREATE TABLE t_use(
   player_id INT,
   sounds_music_id INT,
   PRIMARY KEY(player_id, sounds_music_id),
   FOREIGN KEY(player_id) REFERENCES t_player(player_id),
   FOREIGN KEY(sounds_music_id) REFERENCES t_sounds_music(sounds_music_id)
);

CREATE TABLE t_play(
   level_id INT,
   player_id INT,
   PRIMARY KEY(level_id, player_id),
   FOREIGN KEY(level_id) REFERENCES t_level(level_id),
   FOREIGN KEY(player_id) REFERENCES t_player(player_id)
);

-- Insert data for game

-- Insertion des données de musique pour le niveau 1
INSERT INTO t_sounds_music (music) VALUES ('Space Opera');

-- Insertion du niveau 1
INSERT INTO t_level (level_name, difficulty, sounds_music_id) VALUES 
('Space Battle', 'Facile', 1);

-- Insertion des scores
INSERT INTO t_score (score) VALUES 
('0'),  -- Score pour Alex
('0');  -- Score pour Mia

-- Insertion des joueurs Alex et Mia
INSERT INTO t_player (nickname, HP, placeY, placeX, score_id) VALUES
('Alex', 10, '0', '3', 1),  -- Associer Alex au score 1
('Mia', 10, '0', '4', 2);   -- Associer Mia au score 2

-- Insertion des ennemis pour le niveau 1
INSERT INTO t_enemy (type_of_enemy, HP, placeY, placeX) VALUES
('Alien Fighter', 3, '5', '2'),
('Alien Fighter', 3, '5', '3'),
('Alien Fighter', 3, '6', '2'),
('Alien Bomber', 5, '7', '1'),
('Alien Bomber', 5, '7', '3');

-- Insertion des obstacles pour le niveau 1
INSERT INTO t_obstacle (placeY, placeX, size) VALUES
('4', '1', 'Moyenne'),
('6', '4', 'Grande'),
('8', '2', 'Petite');

-- Association des ennemis avec le niveau 1
INSERT INTO t_belongs (level_id, enemy_id) VALUES
(1, 1), (1, 2), (1, 3), (1, 4), (1, 5);

-- Association des obstacles avec le niveau 1
INSERT INTO t_included (level_id, obstacle_id) VALUES
(1, 1), (1, 2), (1, 3);

-- Associer les joueurs aux niveaux
INSERT INTO t_play (level_id, player_id) VALUES
(1, 1), (1, 2);

-- Validation of modifications
FLUSH PRIVILEGES;