/*----------------------------------------------------------------------------------
TABLO OLUÞTURMA
----------------------------------------------------------------------------------*/

CREATE SEQUENCE seq_satýcý START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_ilan START WITH 1 INCREMENT BY 1;

CREATE TABLE SATICI(
SATICI_ID INT DEFAULT seq_satýcý.NEXTVAL,
SATICI_AD varchar(30),
SATICI_PASS varchar(30),
SATICI_NUMARA varchar(30),
SATICI_ADRES varchar(30),
SATICI_ILAN INT,
SATICI_SON_ISLEM DATE DEFAULT SYSDATE,

CONSTRAINT pri_satýcý PRIMARY KEY (SATICI_ID) 
);

CREATE TABLE ILAN(
ILAN_ID INT DEFAULT seq_ilan.NEXTVAL,
ILAN_TÜR varchar(30),
ILAN_DURUM varchar(30),
ILAN_KIMDEN varchar(30),
ILAN_SATICI_ID INT,
ILAN_FIYAT varchar(30),
ILAN_TARIH DATE DEFAULT SYSDATE,
ILAN_DETAY varchar(300),
ILAN_ADRES varchar(140),
ILAN_TELEFON varchar(20),

CONSTRAINT pri_ilan PRIMARY KEY (ILAN_ID),
CONSTRAINT foreign_ilan FOREIGN KEY (ILAN_SATICI_ID) REFERENCES SATICI (SATICI_ID)
);

/*----------------------------------------------------------------------------------
PROCEDURE 
----------------------------------------------------------------------------------*/

CREATE OR REPLACE PROCEDURE ÝNAKTÝF_TEMÝZLEME AS 
BEGIN

  DELETE FROM SATICI WHERE (to_date(sysdate) - SATICI_TARIH)/365 > 2 AND SATICI_ILAN = 0;

END ÝNAKTÝF_TEMÝZLEME;

/*----------------------------------------------------------------------------------
TRIGGER 1
----------------------------------------------------------------------------------*/
CREATE OR REPLACE TRIGGER ILAN_HESAP
AFTER DELETE OR INSERT ON ILAN 
FOR EACH ROW
BEGIN
  IF INSERTING THEN

  UPDATE SATICI
  SET
  SATICI_ILAN=SATICI_ILAN+1
  WHERE SATICI_ID=:new.ilan_satici_id;
  ELSIF DELETING THEN

  UPDATE SATICI
  SET
  SATICI_ILAN=SATICI_ILAN-1
  WHERE SATICI_ID=:old.ilan_satici_id;

  END IF;

END;

/*----------------------------------------------------------------------------------
TRIGGER 2
----------------------------------------------------------------------------------*/

CREATE OR REPLACE TRIGGER SON_ISLEM 
BEFORE INSERT ON ILAN 
FOR EACH ROW
BEGIN
  UPDATE SATICI
  SET
  SATICI_SON_ISLEM = :new.ILAN_TARIH
  WHERE SATICI_ID = :new.ILAN_SATICI_ID;

END;

