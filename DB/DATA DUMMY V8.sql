-- Create user admin_ identified by admin_;
-- Create user manager identified by manager;
-- Create user sales identified by sales;


-- Grant select on any to manager;
-- Grant update on H_SORDER to manager;

-- Grant select on any to admin;
-- Grant insert on any to admin;
-- Grant update on any to admin;
-- Grant create user to admin;
-- Grant connect to admin with admin option;
-- Grant create view to admin;
-- Grant create trigger to admin;

-- Grant select on contact,D_SORDER,H_SORDER,product,product_price,product_stock,third_party to sales;
-- Grant insert on contact,third_party,D_SORDER,H_SORDER,payment to sales;
-- Grant update on D_SORDER,H_SORDER to sales;

insert into branch values('BA001','Cabang Dinoyo','Surabaya','Jl. Dinoyo 56',to_date('21/02/2017','DD/MM/YYYY'),null,null);
insert into branch values('BA002','Cabang Mulyosari','Surabaya','Jl. Mulyosari 23',to_date('19/02/2014','DD/MM/YYYY'),to_date('21/06/2019','DD/MM/YYYY'),null);
insert into branch values('BA003','Cabang Rungkut','Surabaya','Jl. Rungkut Mejoyo selatan 25',to_date('20/03/2017','DD/MM/YYYY'),null,'Cabang di Rungkut');
insert into branch values('BA004','Cabang Ngagel','Surabaya','Jl. Ngagel Jaya Tengah 12',to_date('18/02/2019','DD/MM/YYYY'),null,'Cabang baru di buka');
insert into branch values('BA005','Cabang Sulawesi','Surabaya','Jl. Sulawesi 32',to_date('16/07/2015','DD/MM/YYYY'),to_date('22/05/2019','DD/MM/YYYY'),null);


insert into user_data values(null,'siti001','siti','Siti Nuryahdi','1','1','ALL');
insert into user_data values(null,'wahyu001','wahyu','Wahyu Gunawan','3','1','BA002');
insert into user_data values(null,'winda001','xuxu','Winda angelina','2','1','BA003');
insert into user_data values(null,'hendra001','loveai','Hendra Lingga','2','0','BA004');
insert into user_data values(null,'jem001','felia','Jem Angkasa','1','0','ALL');
insert into user_data values(null,'lexa001','lexa','Alexandra Sterling','3','1','BA001');
insert into user_data values(null,'maria001','sultan','Maria Sultania','3','1','BA002');
insert into user_data values(null,'dua001','dualipa','Dua Lipa','2','1','BA001');
insert into user_data values(null,'jeremy001','jeremy','Jeremy Anderson','2','1','BA002');

insert into product values('PA001','Product','Faster','Bolpen Faster berwarna hitam',1);
insert into product values('PA002','Product','Faber castell','Pensil 2b',2);
insert into product values('PA003','Product','tupperware','Tempat makan tupperware',3);
insert into product values('PA004','Product','Keiko','Tempat Pensil besi',4);
insert into product values('PA005','Product','Faber castel','Pensil pilot biru ',5);
insert into product values('PA006','Product','Kimmy','Stabilo Kimmy warna kuning',1);
insert into product values('PA007','Product','Snowman','Spidol snowman warna hitan',2);
insert into product values('PA008','Product','Keji','Binder Keji 100 lembar',3);

insert into product_price values('PA001',4000,to_date('14/11/2019','DD/MM/YYYY'));
insert into product_price values('PA002',3000,to_date('12/10/2019','DD/MM/YYYY'));
insert into product_price values('PA003',50000,to_date('10/09/2019','DD/MM/YYYY'));
insert into product_price values('PA004',10000,to_date('11/05/2019','DD/MM/YYYY'));
insert into product_price values('PA005',7000,to_date('13/09/2019','DD/MM/YYYY'));
insert into product_price values('PA006',8000,to_date('08/11/2019','DD/MM/YYYY'));
insert into product_price values('PA007',5000,to_date('03/10/2019','DD/MM/YYYY'));
insert into product_price values('PA008',12000,to_date('05/09/2019','DD/MM/YYYY'));

insert into product_stock values('PA001','BA001',10);
insert into product_stock values('PA002','BA001',90);
insert into product_stock values('PA003','BA001',230);
insert into product_stock values('PA004','BA001',120);
insert into product_stock values('PA005','BA001',102);
insert into product_stock values('PA006','BA001',230);
insert into product_stock values('PA007','BA001',120);
insert into product_stock values('PA008','BA001',230);
insert into product_stock values('PA001','BA002',90);
insert into product_stock values('PA002','BA002',100);
insert into product_stock values('PA003','BA002',230);
insert into product_stock values('PA004','BA002',70);
insert into product_stock values('PA005','BA002',50);
insert into product_stock values('PA006','BA002',200);
insert into product_stock values('PA007','BA002',70);
insert into product_stock values('PA008','BA002',340);
insert into product_stock values('PA001','BA003',400);
insert into product_stock values('PA002','BA003',235);
insert into product_stock values('PA003','BA003',120);
insert into product_stock values('PA004','BA003',525);
insert into product_stock values('PA005','BA003',320);
insert into product_stock values('PA006','BA003',165);
insert into product_stock values('PA007','BA003',200);
insert into product_stock values('PA008','BA003',120);
insert into product_stock values('PA001','BA004',350);
insert into product_stock values('PA002','BA004',125);
insert into product_stock values('PA003','BA004',90);
insert into product_stock values('PA004','BA004',77);
insert into product_stock values('PA005','BA004',450);
insert into product_stock values('PA006','BA004',95);
insert into product_stock values('PA007','BA004',70);
insert into product_stock values('PA008','BA004',87);
insert into product_stock values('PA001','BA005',55);
insert into product_stock values('PA002','BA005',85);
insert into product_stock values('PA003','BA005',55);
insert into product_stock values('PA004','BA005',105);
insert into product_stock values('PA005','BA005',236);
insert into product_stock values('PA006','BA005',79);
insert into product_stock values('PA007','BA005',69);
insert into product_stock values('PA008','BA005',44);

insert into third_party values('TP001','Universitas Kristen Petra Surabaya','UKP','2','Surabaya','60236',' Jl. Siwalankerto No.121-131, Siwalankerto, Kec. Wonocolo','info@petra.ac.id ','http://www.petra.ac.id/','0318439040','0',2);
insert into third_party values('TP002','UIN Sunan Ampel Surabaya','UINSA','1','Surabaya','80234',' Jalan Ahmad Yani No. 117,','Unisa.edu','http://www.Unisa.id/','0318433240','1',2);
insert into third_party values('TP003','Universitas Ubaya Surabaya','UBAYA','4','Surabaya','98431',' Jalan Rungkut Mejoyo no 89','Ubaya.edu ','http://www.Ubaya.id/','0318239040','1',7);
insert into third_party values('TP004','Universitas Airlangga','UNAIR','3','Surabaya','70839','Jl Airlangga No 4-6','Unair.aci.id ','http://www.Unair.id/','0318434340','0',7);
insert into third_party values('TP005','Universitas Negeri Surabaya','UNESA','2','Surabaya','65723',' Jalan Ketintang ','Unesa.ac.id ','http://www.Unesa.id/','0316739040','1',7);

insert into contact values('CO001','Mrs.','Angelina','Gabriella',null,'08735567399','gab.angelina@gmail.com','Surabaya','Mulyosari Prima 23',to_date('21/05/1995','DD/MM/YYYY'),'Surabaya','0','Dosen','TP001',1);
insert into contact values('CO002','Mr.','Michael','Gunawan','0313250253','08535567397','michael@gmail.com','Surabaya','Ngagel Jaya Raya 23',to_date('28/09/1990','DD/MM/YYYY'),'Madura','1','Dosen','TP002',2);
insert into contact values('CO003','Mr.','Kelvin','Tan','0317263245','08132567395','Kelvin@gmail.com','Surabaya','Sulawesi 32',to_date('12/07/1993','DD/MM/YYYY'),'Malang','0','Admin','TP003',3);
insert into contact values('CO004','Mrs.','Liviana','Tansil',null,'08925367392','Liviana@gmail.com','Surabaya','Sumatera 89',to_date('15/10/1997','DD/MM/YYYY'),'Surabaya','1','Rektor','TP004',4);
insert into contact values('CO005','Mrs.','Nadya','Putri',null,'08123567892','Putri@gmail.com','Surabaya','Panjang Jiwo 67',to_date('03/12/1992','DD/MM/YYYY'),'Surabaya','0','Pegawai','TP005',5);

insert into H_SORDER values(null,null,'Draft',sysdate,sysdate,'30 DAYS','bank transfer',null,null,null,'NO',null,'TP001',1,'bambang','BA001');
insert into H_SORDER values(null,null,'Pending',to_date('21/07/2019','DD/MM/YYYY'),to_date('22/07/2019','DD/MM/YYYY'),'30 DAYS','bank transfer',null,null,null,'YES','Sudah di bayar ','TP001',1,'budi','BA001');
insert into H_SORDER values(null,null,'Validated',sysdate,sysdate,'10 DAYS OF MONTH-END','Cash',null,null,null,'YES','Sudah di bayar dengan metode cash','TP002',2,'amir','BA002');
insert into H_SORDER values(null,null,'Rejected',to_date('15/08/2019','DD/MM/YYYY'),to_date('03/09/2019','DD/MM/YYYY'),'10 DAYS OF MONTH-END','Cash',null,null,null,'YES','Sudah di bayar dengan metode cash','TP001',2,'herman','BA002');
insert into H_SORDER values(null,null,'On Delivery',to_date('12/07/2019','DD/MM/YYYY'),to_date('13/07/2019','DD/MM/YYYY'),'DUE UPON RECEIPT','Cheque',null,null,null,'NO','Belum di bayar','TP003',3,'septa','BA003');
insert into H_SORDER values(null,null,'Delivered',to_date('12/09/2019','DD/MM/YYYY'),to_date('12/09/2019','DD/MM/YYYY'),'60 DAYS','Credit card',null,null,null,'NO',null,'TP004',4,'joko','BA004');
insert into H_SORDER values(null,null,'Closed',to_date('13/09/2019','DD/MM/YYYY'),to_date('13/09/2019','DD/MM/YYYY'),'30 DAYS OF MONTH-END','Debit payment order',null,null,null,'NO','Belum di bayar akan membayar dengan metode debit','TP005',5,'irwan','BA005');
insert into H_SORDER values(null,null,'Cancelled',sysdate,sysdate,'ORDER','bank transfer',null,null,null,'YES',null,'TP002',2,'asha','BA002');
insert into H_SORDER values(null,null,'Rejected',to_date('15/09/2019','DD/MM/YYYY'),to_date('15/09/2019','DD/MM/YYYY'),'DELIVERY','Credit card',null,null,null,'NO','21 hari batas pembayaran','TP001',1,'alexa','BA001');
insert into H_SORDER values(null,null,'On Delivery',sysdate,sysdate,'14 DAYS','debit payment order',null,null,null,'NO','Pembayaran akan di lakukan dengan debit','TP003',3,'mark','BA003');

insert into D_SORDER values(1,'PA001','Product','Faster',6000,0,4000,23,null,null,1);
insert into D_SORDER values(2,'PA002','Product','Faber castell',5000,2,3000,10,null,null,1);
insert into D_SORDER values(3,'PA003','Product','tupperware',70000,3,50000,30,null,null,1);
insert into D_SORDER values(4,'PA004','Product','Keiko',12000,0,10000,50,null,null,1);
insert into D_SORDER values(5,'PA005','Product','Faber castell',10000,0,7000,4,null,null,1);
insert into D_SORDER values(6,'PA006','Product','Kimmy',10000,5,8000,23,null,null,1);
insert into D_SORDER values(7,'PA007','Product','Snowman',9000,0,5000,10,null,null,1);
insert into D_SORDER values(8,'PA008','Product','Keji',13000,0,12000,32,null,null,1);
insert into D_SORDER values(9,'PA002','Product','Faber castell',5000,0,3000,45,null,null,1);
insert into D_SORDER values(10,'PA003','Product','tupperware',70000,0,50000,12,null,null,1);
insert into D_SORDER values(10,'PA007','Product','Snowman',9000,0,5000,10,null,null,1);

commit;