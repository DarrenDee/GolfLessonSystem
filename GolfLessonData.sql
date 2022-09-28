--GolfProData.sql

DELETE FROM Lessons;
DELETE FROM GolfPros;
DELETE FROM AppTimes;
DELETE FROM Members;

INSERT INTO AppTimes
VALUES('09:00');
INSERT INTO AppTimes
VALUES('10:00');
INSERT INTO AppTimes
VALUES('11:00');
INSERT INTO AppTimes
VALUES('12:00');
INSERT INTO AppTimes
VALUES('13:00');
INSERT INTO AppTimes
VALUES('14:00');
INSERT INTO AppTimes
VALUES('15:00');
INSERT INTO AppTimes
VALUES('16:00');
INSERT INTO AppTimes
VALUES('17:00');
INSERT INTO AppTimes
VALUES('18:00');

INSERT INTO Members
VALUES(1,'SMITH','JOHN',12, 'johnsmith@gmail.com');
INSERT INTO Members
VALUES(2,'JONES','JOHN',17, 'jonesjohn@yahoo.co.uk');
INSERT INTO Members
VALUES(3,'KELLY','JOHN',12 , 'johnkelly2@gmail.com');
INSERT INTO Members
VALUES(4,'SMITH','JAMES',22, 'jamessmith14@gmail.com');
INSERT INTO Members
VALUES(5,'OSULLIVAN','HARRY',22 , 'harryosullivan@gmail.com');
INSERT INTO Members
VALUES(6,'CASEY','KEVIN',15 , 'kevingcasey45@gmail.com');
INSERT INTO Members
VALUES(7,'STANTON','CHARLIE',8 , 'stantoncharlie99@gmail.com');
INSERT INTO Members
VALUES(8,'HYNES','ALAN',11, 'alanhynes43@yahoo.com');
INSERT INTO Members
VALUES(9,'FITZGERALD','HENRY',14, 'fitzhenry@gmail.com');
INSERT INTO Members
VALUES(10,'ODONNELL','COLM',19 , 'colm234gm@gmail.com');


INSERT INTO GolfPros
VALUES(1,'COLM', 'LEAHY', 'colm23d4sgms@gmail.com' , '0859765433', 90.00, 'R');
INSERT INTO GolfPros
VALUES(2,'CHRIS', 'FLIN', 'chrisflin55@gmail.com' , '0859664213', 95.00, 'R');
INSERT INTO GolfPros
VALUES(3,'RICHARD', 'JONES', 'richardjones@gmail.com' , '0859642433', 100.00, 'R');


INSERT INTO Lessons
VALUES(1,90,'12:00',(TO_DATE('25/03/2022', 'DD/MM/YYYY')),1,2);

INSERT INTO Lessons
VALUES(2,90,'15:00',(TO_DATE('27/03/2022', 'DD/MM/YYYY')),1,8);

INSERT INTO Lessons
VALUES(3,90,'13:00',(TO_DATE('25/03/2022', 'DD/MM/YYYY')),1,9);

INSERT INTO Lessons
VALUES(4,95,'16:00',(TO_DATE('28/03/2022', 'DD/MM/YYYY')),2,6);

INSERT INTO Lessons
VALUES(5,95,'09:00',(TO_DATE('24/03/2022', 'DD/MM/YYYY')),2,8);

INSERT INTO Lessons
VALUES(6,95,'17:00',(TO_DATE('24/03/2022', 'DD/MM/YYYY')),2,1);

INSERT INTO Lessons
VALUES(7,100,'13:00',(TO_DATE('25/03/2022', 'DD/MM/YYYY')),3,7);


INSERT INTO Lessons
VALUES(8,95,'14:00',(TO_DATE('05/04/2022', 'DD/MM/YYYY')),2,8);

INSERT INTO Lessons
VALUES(9,95,'14:00',(TO_DATE('02/04/2022', 'DD/MM/YYYY')),2,8);

INSERT INTO Lessons
VALUES(10,95,'15:30',(TO_DATE('02/05/2022', 'DD/MM/YYYY')),2,8);




COMMIT;
