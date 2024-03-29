/*
ATURAN SIMPLE DATABASE
KODE = AUTOGEN NUMBER
ID = TEXT VARCHAR ID
*/

SELECT 'DROP TABLE ' || TNAME || ' CASCADE CONSTRAINT PURGE;' FROM TAB;

DROP TABLE BRANCH CASCADE CONSTRAINT PURGE;
DROP TABLE CONTACT CASCADE CONSTRAINT PURGE;
DROP TABLE D_SORDER CASCADE CONSTRAINT PURGE;
DROP TABLE H_SORDER CASCADE CONSTRAINT PURGE;
DROP TABLE PRODUCT CASCADE CONSTRAINT PURGE;
DROP TABLE PRODUCT_PRICE CASCADE CONSTRAINT PURGE;
DROP TABLE PRODUCT_STOCK CASCADE CONSTRAINT PURGE;
DROP TABLE SSH_VARIABLES CASCADE CONSTRAINT PURGE;
DROP TABLE THIRD_PARTY CASCADE CONSTRAINT PURGE;
DROP TABLE USER_DATA CASCADE CONSTRAINT PURGE;
DROP VIEW V_AKSES;
DROP VIEW V_BRANCH;
DROP VIEW V_DETAIL_PRODUK;
DROP VIEW V_THIRD_PARTY;
DROP VIEW V_USER_SALES;
DROP VIEW V_DETAIL_ORDER;


CREATE TABLE BRANCH(
    ID_BRANCH VARCHAR2(13) PRIMARY KEY,
    BRANCH_NAME VARCHAR2(50),
    CITY VARCHAR2(20),
    BRANCH_ADDRESS VARCHAR2(100),
    OPENING_DATE DATE NOT NULL,
    CLOSING_DATE DATE,
    NOTES VARCHAR2(200)
);


/* U_STATUS
1. Admin -> Semua Akses
2. Manager -> Approve & Reject, Ga Bisa Insert
3. Sales -> Cuman Insert & Cancel

ID_BRANCH
-> UNTUK USER ADMIN ID_BRANCH = ALL (SUDAH TAK BUATNO INSERT DI PALING BAWAH)

U_ACTIVE_STATUS
0 = GA AKTIF
1 = AKTIF
*/
CREATE TABLE USER_DATA(
    USER_ROW_ID NUMBER PRIMARY KEY,
    USERNAME VARCHAR2(13) UNIQUE NOT NULL,
    U_PASSWORD VARCHAR2(13) NOT NULL,
    U_NAME VARCHAR2(50) NOT NULL,
    U_STATUS VARCHAR2(1) NOT NULL,
    U_ACTIVE_STATUS VARCHAR2(1) NOT NULL,
    ID_BRANCH VARCHAR2(13) REFERENCES BRANCH(ID_BRANCH)
);



/*STATUS_PRODUCT
- PRODUCT
- JASA 
*/
CREATE TABLE PRODUCT(
    ID_PRODUCT VARCHAR2(13) PRIMARY KEY,
    PRODUCT_TYPE VARCHAR2(20),
    PRODUCT_NAME VARCHAR2(100) NOT NULL,
    PRODUCT_DESC VARCHAR2(200),
    USER_ROW_ID NUMBER REFERENCES USER_DATA(USER_ROW_ID)
);

CREATE TABLE PRODUCT_PRICE(
    ID_PRODUCT VARCHAR2(13) REFERENCES PRODUCT(ID_PRODUCT),
    COSTPRICE NUMBER NOT NULL,
    PRICE_DATE DATE NOT NULL,
    CONSTRAINT PK_PRODUCT_PRICE PRIMARY KEY (ID_PRODUCT,PRICE_DATE)
);

CREATE TABLE PRODUCT_STOCK(
    ID_PRODUCT VARCHAR2(13) REFERENCES PRODUCT(ID_PRODUCT),
    ID_BRANCH VARCHAR2(13) REFERENCES BRANCH(ID_BRANCH),
    QTY NUMBER,
    CONSTRAINT PK_PRODUCT_STOCK PRIMARY KEY(ID_PRODUCT,ID_BRANCH)
);


/*THIRD_PARTY_TYPE
- Prospect
- Customer
- Vendor
- Others

ACTIVE_STATUS
- TIDAK AKTIF
- AKTIF
*/
CREATE TABLE THIRD_PARTY(
    ID_THIRD_PARTY VARCHAR2(13) PRIMARY KEY,
    FORMAL_NAME VARCHAR2(50) NOT NULL,
    ALIAS_NAME VARCHAR2(50),
    THIRD_PARTY_TYPE VARCHAR2(15) NOT NULL,
    CITY VARCHAR2(20),
    POSTAL_CODE VARCHAR2(5),
    ADDRESS VARCHAR2(100),
    EMAIL VARCHAR2(50),
    WEBSITE VARCHAR2(50),
    PHONE_NUMBER VARCHAR2(15),
    ACTIVE_STATUS VARCHAR2(15) NOT NULL,
    USER_ROW_ID NUMBER REFERENCES USER_DATA(USER_ROW_ID)
);

/*ACTIVE_STATUS
0 = GA AKTIF
1 = AKTIF
*/
CREATE TABLE CONTACT(
    ID_CONTACT VARCHAR2(13) PRIMARY KEY,
    FORMAL_TITLE VARCHAR2(5),
    LAST_NAME VARCHAR2(25),
    FIRST_NAME VARCHAR2(25),
    PHONE_NUMBER VARCHAR2(15),
    MOBILE_NUMBER VARCHAR2(15),
    EMAIL VARCHAR2(50),
    CITY VARCHAR2(20),
    ADDRESS VARCHAR2(100),
    DATE_OF_BIRTH DATE,
    PLACE_OF_BIRTH VARCHAR2(50),
    ACTIVE_STATUS VARCHAR2(1) NOT NULL,
    JOB_POSITION VARCHAR2(50),
    ID_THIRD_PARTY VARCHAR2(13) REFERENCES THIRD_PARTY(ID_THIRD_PARTY),
    USER_ROW_ID NUMBER REFERENCES USER_DATA(USER_ROW_ID),
    CONSTRAINT CH_FORMAL_TITLE CHECK(UPPER(FORMAL_TITLE) = 'MR.' OR UPPER(FORMAL_TITLE) = 'MRS.' OR UPPER(FORMAL_TITLE) = 'MS.')
);

/*PAYMENT_TYPE
- bank transfer
- cash
- cheque
- credit card
- debit payment order

ORDER_STATUS
- Draft
- Pending
- Validated
- Rejected
- On Delivery
- Delivered
- Closed
- Cancelled
*/
CREATE TABLE H_SORDER(
    ORDER_ROW_ID NUMBER PRIMARY KEY,
    INVOICE_NUMBER VARCHAR2(15),
    ORDER_STATUS VARCHAR2(20) NOT NULL,
    ORDER_CREATED_DATE DATE NOT NULL,
    DELIVERY_DATE DATE NOT NULL,
    PAYMENT_TERMS VARCHAR2(30),
    PAYMENT_TYPE VARCHAR2(30),
    AMOUNT_OF_TAX NUMBER,
    GROSS_TOTAL NUMBER,
    NET_TOTAL NUMBER,
    STATUS_BILLED VARCHAR2(3) CONSTRAINT CH_STATUS_BILLED CHECK(UPPER(STATUS_BILLED) = 'YES' OR UPPER(STATUS_BILLED) = 'NO'),
    NOTES VARCHAR2(200),
    ID_THIRD_PARTY VARCHAR2(13) REFERENCES THIRD_PARTY(ID_THIRD_PARTY),
    SALES_ROW_ID NUMBER REFERENCES USER_DATA(USER_ROW_ID),
    CUSTOMER_NAME VARCHAR2(30),
    ID_BRANCH VARCHAR2(13) REFERENCES BRANCH(ID_BRANCH),
    CONSTRAINT CH_HSORDER_DATE CHECK(DELIVERY_DATE >= ORDER_CREATED_DATE)
);

--MARK UP RATE = PERSEN HRG_INPUT DIRUBAH DARI HPP BERAPA--  (Input Price - Cost Price) / Input Price
--MARGIN RATE = PERSEN KEUNTUNGAN DARI HPP-- (Input Price - Cost Price) / Cost Price
CREATE TABLE D_SORDER(
    ORDER_ROW_ID NUMBER REFERENCES H_SORDER(ORDER_ROW_ID),
    ID_PRODUCT VARCHAR2(13),
    PRODUCT_TYPE VARCHAR2(20),
    PRODUCT_NAME VARCHAR2(100) CONSTRAINT NN_PRODUCT_NAME NOT NULL,
    INPUT_PRICE NUMBER NOT NULL,
    REDUCTION_RATE NUMBER,
    COSTPRICE NUMBER,
    QTY NUMBER NOT NULL,
    MARKUP_RATE NUMBER,
    MARGIN_RATE NUMBER,
    DETAIL_ROW_ID NUMBER,
    --CONSTRAINT PK_D_SORDER PRIMARY KEY(ORDER_ROW_ID,PRODUCT_NAME)--
    CONSTRAINT PK_D_SORDER PRIMARY KEY(ORDER_ROW_ID, DETAIL_ROW_ID)
);

--SSH VARIABLES--
CREATE TABLE SSH_VARIABLES(
    SSH_VARIABLES_ROW_ID NUMBER,
    TIPE VARCHAR2(50),
    ISI VARCHAR2(50)
);

--TRIGGER--
CREATE OR REPLACE TRIGGER T_AUTOGEN_USERROW_ID
BEFORE INSERT ON USER_DATA
FOR EACH ROW
DECLARE
    TID NUMBER;
BEGIN
    SELECT COUNT(USER_ROW_ID) + 1 INTO TID FROM USER_DATA;
    :NEW.USER_ROW_ID := TID;
END;
/

CREATE OR REPLACE TRIGGER T_AUTOGEN_SSH
BEFORE INSERT ON SSH_VARIABLES
FOR EACH ROW
DECLARE
    TID NUMBER;
BEGIN
    SELECT COUNT(SSH_VARIABLES_ROW_ID) + 1 INTO TID FROM SSH_VARIABLES;
    :NEW.SSH_VARIABLES_ROW_ID := TID;
END;
/

CREATE OR REPLACE TRIGGER T_AUTOGEN_DETAIL_ROW_ID
BEFORE INSERT ON D_SORDER
FOR EACH ROW
DECLARE
    TID NUMBER;
BEGIN
    SELECT COUNT(DETAIL_ROW_ID) + 1 INTO TID FROM D_SORDER WHERE ORDER_ROW_ID = :NEW.ORDER_ROW_ID;
    :NEW.DETAIL_ROW_ID:= TID;
END;
/


CREATE OR REPLACE TRIGGER T_AUTOGEN_ID_THIRD_PARTY
BEFORE INSERT ON THIRD_PARTY
FOR EACH ROW
DECLARE
    TCTR NUMBER;
BEGIN
    SELECT COUNT(ID_THIRD_PARTY) + 1 INTO TCTR FROM THIRD_PARTY WHERE ID_THIRD_PARTY LIKE 'TP%';
    :NEW.ID_THIRD_PARTY := 'TP' || LPAD(TCTR,3,'0');
END;
/

CREATE OR REPLACE TRIGGER T_AUTOGEN_ID_CONTACT
BEFORE INSERT ON CONTACT
FOR EACH ROW
DECLARE
    TCTR NUMBER;
BEGIN
    SELECT COUNT(ID_CONTACT) + 1 INTO TCTR FROM CONTACT WHERE ID_CONTACT LIKE 'CO%';
    :NEW.ID_CONTACT := 'CO' || LPAD(TCTR,3,'0');
END;
/

CREATE OR REPLACE TRIGGER T_CHANGE_HSORDER
AFTER INSERT ON D_SORDER
FOR EACH ROW
DECLARE
    T_NET_AWAL NUMBER;
    T_NET NUMBER;
    T_TAX NUMBER;
    T_GROSS NUMBER;
BEGIN
    T_NET := :NEW.INPUT_PRICE * :NEW.QTY;
    SELECT NVL(NET_TOTAL,0) INTO T_NET_AWAL FROM H_SORDER 
    WHERE ORDER_ROW_ID = :NEW.ORDER_ROW_ID;
    T_NET := T_NET + T_NET_AWAL;
    T_TAX := (10 / 100) * T_NET;
    T_GROSS := (10 / 100) * T_NET + T_NET;
    UPDATE H_SORDER SET NET_TOTAL = T_NET, AMOUNT_OF_TAX = T_TAX, GROSS_TOTAL = T_GROSS WHERE ORDER_ROW_ID = :NEW.ORDER_ROW_ID;  
END;
/

CREATE OR REPLACE TRIGGER T_AUTOGEN_HSORDER
BEFORE INSERT ON H_SORDER
FOR EACH ROW
DECLARE
    TID NUMBER;
    TCTR NUMBER;
    T_INVOICE VARCHAR2(15);
BEGIN
    SELECT COUNT(ORDER_ROW_ID) + 1 INTO TID FROM H_SORDER;
    :NEW.ORDER_ROW_ID := TID;
    SELECT 'N' || TO_CHAR(SYSDATE, 'DDMMYY') INTO T_INVOICE FROM DUAL;
    SELECT COUNT(T_INVOICE) + 1 INTO TCTR FROM H_SORDER WHERE INVOICE_NUMBER LIKE T_INVOICE || '%';
    :NEW.INVOICE_NUMBER := T_INVOICE || LPAD(TCTR,5,'0');
END;
/


/*
CREATE OR REPLACE TRIGGER T_D_SORDER
BEFORE INSERT ON D_SORDER
FOR EACH ROW
DECLARE
    TCTR NUMBER;
    T_ID PRODUCT.ID_PRODUCT%TYPE;
    TCOSTPRICE NUMBER;
    TNAME PRODUCT.PRODUCT_NAME%TYPE;
    T_TYPE PRODUCT.PRODUCT_TYPE%TYPE;
    T_INP_PRICE NUMBER;
    T_MARKUP NUMBER;
    T_MARGIN NUMBER;
BEGIN
    TCOSTPRICE := :NEW.COSTPRICE;
    T_INP_PRICE := :NEW.INPUT_PRICE;
    T_TYPE := :NEW.PRODUCT_TYPE;
    T_ID := :NEW.ID_PRODUCT;
    SELECT NVL(COUNT(ID_PRODUCT),0) INTO TCTR FROM PRODUCT 
    WHERE PRODUCT_NAME = :NEW.PRODUCT_NAME;
    IF NVL(TCOSTPRICE,0) = 0 THEN
        :NEW.COSTPRICE := 0;
        TCOSTPRICE := 0;
    END IF;
    IF NVL(T_INP_PRICE,0) = 0 THEN
        :NEW.INPUT_PRICE := 0;
        T_INP_PRICE := 0;
    END IF;
    :NEW.MARKUP_RATE := (T_INP_PRICE - TCOSTPRICE) / T_INP_PRICE;
    :NEW.MARGIN_RATE := (T_INP_PRICE - TCOSTPRICE) / TCOSTPRICE;
END;
/


IF TCTR = 0 THEN --NOT A PREDEFINED PRODUCT--
    TCTR := 0;
ELSIF TCTR > 0 THEN --IS A PREDEFINED PRODUCT--
    SELECT ID_PRODUCT INTO T_ID FROM PRODUCT 
    WHERE PRODUCT_NAME = :NEW.PRODUCT_NAME;
    SELECT COSTPRICE INTO TCOSTPRICE FROM PRODUCT_PRICE
    WHERE ID_PRODUCT = T_ID;
    SELECT PRODUCT_TYPE INTO T_TYPE FROM PRODUCT
    WHERE PRODUCT_TYPE = T_TYPE;
END IF;

*/

--------------------FUNCTION----------------------
CREATE OR REPLACE FUNCTION F_MARKUP(
    PID D_SORDER.ORDER_ROW_ID%TYPE,
    PNAMA D_SORDER.PRODUCT_NAME%TYPE
)
RETURN NUMBER
IS
    T_INP_PRICE NUMBER;
    TCOSTPRICE NUMBER;
    T_MARKUP NUMBER;
BEGIN
    SELECT INPUT_PRICE INTO T_INP_PRICE FROM D_SORDER WHERE ORDER_ROW_ID = PID AND UPPER(PRODUCT_NAME) = UPPER(PNAMA);
    SELECT COSTPRICE INTO TCOSTPRICE FROM D_SORDER WHERE ORDER_ROW_ID = PID AND UPPER(PRODUCT_NAME) = UPPER(PNAMA);
    T_MARKUP := (T_INP_PRICE - TCOSTPRICE) /T_INP_PRICE;
    RETURN T_MARKUP;
END;
/


CREATE OR REPLACE FUNCTION F_MARGIN(
    PID H_SORDER.ORDER_ROW_ID%TYPE,
    PNAMA D_SORDER.PRODUCT_NAME%TYPE
)
RETURN NUMBER
IS
    T_INP_PRICE NUMBER;
    TCOSTPRICE NUMBER;
    T_MARGIN NUMBER;
BEGIN
    SELECT INPUT_PRICE INTO T_INP_PRICE FROM D_SORDER WHERE ORDER_ROW_ID = PID AND UPPER(PRODUCT_NAME) = UPPER(PNAMA);
    SELECT COSTPRICE INTO TCOSTPRICE FROM D_SORDER WHERE ORDER_ROW_ID = PID AND UPPER(PRODUCT_NAME) = UPPER(PNAMA);
    T_MARGIN := (T_INP_PRICE - TCOSTPRICE) /TCOSTPRICE;
    RETURN T_MARGIN;
END;
/

-------------------------------------------------
--VIEW--
CREATE OR REPLACE VIEW V_THIRD_PARTY AS
SELECT 
    ID_THIRD_PARTY AS ID, 
    FORMAL_NAME AS FORMAL, 
    ALIAS_NAME AS ALIAS,
    THIRD_PARTY_TYPE AS TYPE,
    USER_ROW_ID as INSERTING_USER
FROM THIRD_PARTY
ORDER BY 2 ASC, 3 ASC;


CREATE OR REPLACE VIEW V_AKSES AS
SELECT
    USER_ROW_ID, USERNAME,U_NAME AS NAMA, 
    U_PASSWORD AS PW, U_STATUS AS JABATAN, U_ACTIVE_STATUS AS STATUS_AKTIF
FROM USER_DATA
ORDER BY U_STATUS DESC, U_NAME ASC;


CREATE OR REPLACE VIEW V_USER_SALES AS
SELECT * FROM V_AKSES WHERE JABATAN = '3'
ORDER BY NAMA ASC;


CREATE OR REPLACE VIEW V_BRANCH AS
SELECT ID_BRANCH, BRANCH_NAME FROM BRANCH
ORDER BY 2 ASC;


CREATE OR REPLACE VIEW V_DETAIL_PRODUK AS
SELECT 
    P.ID_PRODUCT AS ID,
    P.PRODUCT_TYPE AS TYPE,
    P.PRODUCT_NAME AS NAME,
    P.USER_ROW_ID AS INSERTING_USER,
    PP.COSTPRICE,
    NVL(PS.ID_BRANCH,'-') AS ID_BRANCH,
    NVL(B.BRANCH_NAME,'-') AS BRANCH_NAME,
    NVL(PS.QTY,0) AS STOCK
FROM PRODUCT P
LEFT JOIN PRODUCT_PRICE PP
ON P.ID_PRODUCT = PP.ID_PRODUCT
LEFT JOIN PRODUCT_STOCK PS
ON PS.ID_PRODUCT = P.ID_PRODUCT
LEFT JOIN BRANCH B
ON B.ID_BRANCH = PS.ID_BRANCH
WHERE PP.PRICE_DATE IN(
    SELECT MAX(PRICE_DATE) FROM PRODUCT_PRICE WHERE ID_PRODUCT = P.ID_PRODUCT
);

CREATE OR REPLACE VIEW V_DETAIL_ORDER AS
SELECT 
    ORDER_ROW_ID,
    P.PRODUCT_NAME AS NAMA,
    DO.INPUT_PRICE,
    DO.REDUCTION_RATE,
    DO.COSTPRICE,
    NVL(DO.MARGIN_RATE,0) AS MARGIN,
    NVL(DO.MARKUP_RATE,0) AS MARKUP
FROM 
    PRODUCT P, D_SORDER DO
WHERE P.ID_PRODUCT = DO.ID_PRODUCT;


--BRANCH UNTUK USER ADMIN--
INSERT INTO BRANCH (ID_BRANCH,BRANCH_NAME, OPENING_DATE) VALUES('ALL','ALL',TO_DATE('01/01/1945','DD/MM/YYYY'));

--SSH VARIABLES--
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','SECRETARY');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','HRD STAFF');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','HRD MANAGER');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','GENERAL MANAGER');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','OTHER MANAGER');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','CEO');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','OTHER STAFF');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','SALES STAFF');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('JOB_POSITION','OTHERS');

INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('TITLE','MR.');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('TITLE','MRS.');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('TITLE','MS.');

INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','DUE UPON RECEIPT');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','30 DAYS');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','30 DAYS OF MONTH-END');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','60 DAYS');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','60 DAYS OF MONTH-END');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','ORDER');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','DELIVERY');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','10 DAYS');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','10 DAYS OF MONTH-END');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','14 DAYS');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TERMS','14 DAYS OF MONTH-END');

INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TYPE','BANK TRANSFER');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TYPE','CASH');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TYPE','CHEQUE');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TYPE','CREDIT CARD');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('PAYMENT_TYPE','DEBIT PAYMENT ORDER');

INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','DRAFT');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','PENDING');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','VALIDATED');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','REJECTED');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','ON DELIVERY');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','DELIVERED');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','CLOSED');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ORDER_STATUS','CANCELLED');

INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('THIRD_PARTY_TYPE','PROSPECT');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('THIRD_PARTY_TYPE','CUSTOMER');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('THIRD_PARTY_TYPE','VENDOR');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('THIRD_PARTY_TYPE','OTHERS');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('THIRD_PARTY_TYPE','ALL');

INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ACTIVE_STATUS','NON ACTIVE');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ACTIVE_STATUS','ACTIVE');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('ACTIVE_STATUS','ALL');

INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('USER_TYPE','ADMIN');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('USER_TYPE','MANAGER');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('USER_TYPE','SALES');
INSERT INTO SSH_VARIABLES(TIPE,ISI) VALUES('USER_TYPE','ALL');

COMMIT;