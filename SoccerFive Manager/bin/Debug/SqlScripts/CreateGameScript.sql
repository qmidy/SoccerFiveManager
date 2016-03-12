PRAGMA foreign_keys=ON;

CREATE TABLE club (id INT NOT NULL PRIMARY KEY, name VARCHAR(20));

CREATE TABLE team (id INT NOT NULL PRIMARY KEY, club_id INT,  FOREIGN KEY (club_id) REFERENCES club(id));

CREATE TABLE player (id INT NOT NULL PRIMARY KEY, name VARCHAR(20), team_id INT, area INT, number INT, attack INT, defense INT, FOREIGN KEY (team_id) REFERENCES team(id));

INSERT INTO club VALUES ('1','{0}');

INSERT INTO team VALUES ('1','1');

INSERT INTO player VALUES ('1','Tom','1','0','1','10','10');
INSERT INTO player VALUES ('2','Dédé','1','0','2','10','10');
INSERT INTO player VALUES ('3','Fanch','1','0','3','10','10');
INSERT INTO player VALUES ('4','Eric','1','0','4','10','10');
INSERT INTO player VALUES ('5','Pierre','1','0','5','10','10');

INSERT INTO club VALUES ('2','Club2');
INSERT INTO team VALUES ('2','2');

INSERT INTO club VALUES ('3','Club3');
INSERT INTO team VALUES ('3','3');

INSERT INTO club VALUES ('4','Club4');
INSERT INTO team VALUES ('4','4');

INSERT INTO player VALUES ('6','Player1','2','0','1','10','10');
INSERT INTO player VALUES ('7','Player2','2','0','2','10','10');
INSERT INTO player VALUES ('8','Player3','2','0','3','10','10');
INSERT INTO player VALUES ('9','Player4','2','0','4','10','10');
INSERT INTO player VALUES ('10','Player5','2','0','5','10','10');

INSERT INTO player VALUES ('11','Player1','3','0','1','10','10');
INSERT INTO player VALUES ('12','Player2','3','0','2','10','10');
INSERT INTO player VALUES ('13','Player3','3','0','3','10','10');
INSERT INTO player VALUES ('14','Player4','3','0','4','10','10');
INSERT INTO player VALUES ('15','Player5','3','0','5','10','10');

INSERT INTO player VALUES ('16','Player1','4','0','1','10','10');
INSERT INTO player VALUES ('17','Player2','4','0','2','10','10');
INSERT INTO player VALUES ('18','Player3','4','0','3','10','10');
INSERT INTO player VALUES ('19','Player4','4','0','4','10','10');
INSERT INTO player VALUES ('20','Player5','4','0','5','10','10');

