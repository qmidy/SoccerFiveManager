PRAGMA foreign_keys=ON;

CREATE TABLE club (id INT NOT NULL PRIMARY KEY, name VARCHAR(20), description VARCHAR(2000));

CREATE TABLE championship(id INT NOT NULL PRIMARY KEY);

CREATE TABLE team (id INT NOT NULL PRIMARY KEY, club_id INT, championship_id INT, FOREIGN KEY (club_id) REFERENCES club(id), FOREIGN KEY (championship_id) REFERENCES championship(id));

CREATE TABLE player (id INT NOT NULL PRIMARY KEY, name VARCHAR(20), team_id INT, area INT, number INT, attack INT, defense INT, experience INT, FOREIGN KEY (team_id) REFERENCES team(id));

CREATE TABLE match (id INT NOT NULL PRIMARY KEY, team1_id INT, team2_id INT, championship_id INT, score1 INT, score2 INT, FOREIGN KEY (team1_id) REFERENCES team(id), FOREIGN KEY (team2_id) REFERENCES team(id), FOREIGN KEY (championship_id) REFERENCES championship(id));
