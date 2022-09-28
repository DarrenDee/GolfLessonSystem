DROP TABLE Lessons;
DROP TABLE GolfPros;
DROP TABLE Members;
DROP Table AppTimes;



CREATE TABLE Members
(MemberId numeric(4) NOT NULL,
Surname varchar2(20) NOT NULL,
Forename varchar2(20)NOT NULL,
Handicap numeric(2),
Email varchar2(50),
CONSTRAINT pk_Members PRIMARY KEY (MemberID));

CREATE TABLE GolfPros
(ProID numeric(3) NOT NULL,
 Forename varchar2(20) NOT NULL,
 Surname varchar2(20) NOT NULL,
 Email   varchar(50),
 PhoneNumber varchar(10),
 Fee      decimal(5,2),
 Status   char(1) NOT NULL,
 CONSTRAINT pk_ProID PRIMARY KEY (ProID));

CREATE TABLE AppTimes
(AppTime char(5),
CONSTRAINT pk_AppTime PRIMARY KEY (AppTime));


CREATE TABLE Lessons
(BookingNumber numeric(5) NOT NULL,
Cost decimal(6,2) NOT NULL,
AppTime char(5) NOT NULL,
AppDate date,
ProID numeric(3) NOT NULL,
MemberID numeric (4) NOT NULL,
CONSTRAINT pk_BookingNumber PRIMARY KEY (BookingNumber),
CONSTRAINT fk_MemberID FOREIGN KEY (MemberID) REFERENCES Members,
CONSTRAINT fk_ProID FOREIGN KEY (ProID) REFERENCES GolfPros);

