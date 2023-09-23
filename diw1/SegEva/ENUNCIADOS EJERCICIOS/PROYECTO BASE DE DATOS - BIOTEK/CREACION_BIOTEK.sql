Create DataBase BIOTEK
ON PRIMARY( 
NAME= Biotek_BD, 
FILENAME='D:\DIW\biotek.MDF') 
go

Use BIOTEK
go

drop table Usuarios;

create table Usuarios
(idUsuario int constraint PKUsuarios Primary Key,
nombre nvarchar(25),
email nvarchar(25) not null unique,
password nvarchar(15) not null);

drop table Ranking;

create table Ranking(
idUsuario int constraint FKUsuarios references Usuarios(IdUsuario),
fecha datetime,
puntuacion smallint
constraint PKRanking Primary Key(idUsuario,fecha));


drop table Preguntas;

create table Preguntas 
(idPregunta int constraint PKPreguntas Primary Key,
texto nvarchar(254),
fecha datetime,
tipo nvarchar(6));

insert into Preguntas VALUES (1,'Selecciona el posible resultado que se obtendr�a si la bacteria a estudiar careciera de la enzima fotoliasa','06/08/2015','imagen');
insert into Preguntas VALUES (2,'A la vista de estos resultados �Cu�l ser�a la interpretaci�n correcta?','07/05/2015','texto');
insert into Preguntas VALUES (3,'Se�ala la opci�n correcta','07/05/2015','texto');
insert into Preguntas VALUES (4,'Se�ala la opci�n verdadera entre las siguientes proposiciones','07/05/2015','texto');
insert into Preguntas VALUES (5,'�Qu� efectos produce en el DNA bacteriano una exposici�n a la luz UV? Elige la respuesta correcta','07/05/2015','texto');
insert into Preguntas VALUES (6,'Elige la respuesta correcta','07/05/2015','texto');
insert into Preguntas VALUES (7,'Si la siguiente mol�cula de DNA sufre una mutaci�n con luz UV, �cu�l de las siguientes cadenas corresponde al mRNA?','07/05/2015','imagen');
insert into Preguntas VALUES (8,'�Qu� prote�na se forma al traducir el siguiente mRNA?','07/05/2015','texto');
insert into Preguntas VALUES (9,'Se�ala la opci�n correcta','07/05/2015','texto');
insert into Preguntas VALUES (10,'�Por qu� los agentes mutag�nicos biol�gicos se denominan  genes saltarines? ','07/05/2015','texto');

drop table Respuestas;
create table Respuestas
(idPregunta int constraint FKPreguntas references Preguntas(idPregunta),
idRespuesta char(1),
correcto bit,
explicacion nvarchar(max),
texto nvarchar(max),
constraint PKRespuestas PRIMARY KEY (idPregunta,idRespuesta));

insert into Respuestas VALUES (1,'A',0,'En esta opci�n la luz UV ha mutado un % de bacterias ya que se aprecia una clara disminuci�n en el n�mero de ufc (unidades formadoras de colonias) mientras que, en el caso del cultivo fotorreactivado, el n�mero de colonias es mayor que el de las mutadas lo que indica que <B> la bacteria presenta la enzima fotoliasa </B>.

Por otra parte, el n�mero de colonias apreciadas en la fotorreactivaci�n sigue siendo inferior al n�mero de colonias crecidas en el control lo que indica que en el proceso de mutaci�n parte de ellas no han sobrevivido.
','IMAGENES/SolucionA.jpg');
insert into Respuestas VALUES (1,'B',1,'En esta opci�n la luz UV ha mutado un % de bacterias ya que se aprecia una clara disminuci�n en el n�mero de ufc (unidades formadoras de bacterias) mientras que, en el caso del cultivo fotorreactivado, el n�mero de colonias es igual que el de las mutadas lo que indica que <B> la bacteria NO presenta la enzima fotoliasa </B>.

Por otra parte, el n�mero de colonias apreciadas en la fotorreactivaci�n sigue siendo inferior al n�mero de colonias crecidas en el control lo que indica que en el proceso de mutaci�n parte de ellas no han sobrevivido.
','IMAGENES/SolucionB.jpg');
insert into Respuestas VALUES (1,'C',0,'Mientras que el crecimiento en la placa control es el esperado, en esta opci�n  no se observa crecimiento en el cultivo sometido a luz UV ni tampoco en el sometido a fotorreactivaci�n, lo cual indica que ninguna bacteria ha sobrevivido al proceso de mutaci�n por lo que <B> no se puede determinar si la bacteria tiene o no la enzima fotoliasa </B>.','IMAGENES/SolucionC.jpg');

insert into Respuestas VALUES (2,'A',0,'A  mayor tiempo de exposici�n a la luz UV, hay un <B> menor </B> crecimiento bacteriano.','A mayor tiempo de exposici�n a la luz UV, mayor crecimiento bacteriano, lo que implica que un aumento en el tiempo de fotorreactivaci�n aumenta la recuperaci�n de bacterias.');
insert into Respuestas VALUES (2,'B',0,'Un aumento en el tiempo de fotorreactivaci�n <B> aumenta la recuperaci�n </B> de bacterias.','A mayor tiempo de exposici�n a la luz UV, menor crecimiento bacteriano, lo que implica que un aumento en el tiempo de fotorreactivaci�n disminuye la recuperaci�n de bacterias.');
insert into Respuestas VALUES (2,'C',1,'Tu respuesta es CORRECTA','A mayor tiempo de exposici�n a la luz UV, menor crecimiento bacteriano, igual que cuanto menor sea el tiempo de exposici�n a la luz visible, menor ser� el crecimiento.');


insert into Respuestas VALUES (3,'A',0,'La enzima fotoliasa est� presente pr�cticamente en todos los procariotas y en algunos eucariotas; sin embargo <B> los mam�feros carecen de ella </B> por lo tanto no pueden reparar el DNA da�ado por la luz UV  mediante este sistema','La enzima fotoliasa se encuentra en todos los mam�feros por lo cual nos ayuda a reparar el da�o causado por la luz UV en el DNA humano.');
insert into Respuestas VALUES (3,'B',0,'Tras la irradiaci�n  con luz UV de un cultivo de bacterias que posee la  enzima fotoliasa, <B> se puede reducir </B> el efecto germicida si el cultivo es expuesto inmediatamente a un intenso foco de luz visible','Tras la irradiaci�n  con luz UV de un cultivo de bacterias que posee la  enzima fotoliasa, se puede aumentar el efecto germicida si el cultivo es expuesto inmediatamente a un intenso foco de luz visible.');
insert into Respuestas VALUES (3,'C',1,'Tu respuesta es CORRECTA','Una de las consecuencias de la acci�n de la luz UV en el DNA es la formaci�n de d�meros de pirimidina.');


insert into Respuestas VALUES (4,'A',1,'Tu respuesta es correcta.','a)	Las soluciones acuosas diluidas de sales son f�cilmente penetrables por radiaci�n UV, no as� los medios de cultivo habituales como el CN y TSB.');
insert into Respuestas VALUES (4,'B',0,'La luz UV tiene<B> bajo poder penetrante</B>, lo que hace que   
          una  gran concentraci�n de bacterias pueda producir un efecto de 
         apantallamiento y por lo tanto, una absorci�n parcial de la misma.
','b)	Debido al alto poder penetrante de la luz UV, una gran concentraci�n de bacterias puede producir un efecto de apantallamiento.');
insert into Respuestas VALUES (4,'C',0,'La radiosensibilidad<B> es diferente</B> seg�n en qu� momento de la curva de crecimiento se encuentre el microorganismo.
<p> - hay m�s sensibilidad en la fase exponencial porque la relaci�n de DNA/Volumen es mayor que en cualquier otra fase.</p>
<p> - decrece en la fase estacionaria. </p>
<p> - baja en la de latencia.</p>','c)	La radiosensibilidad es la misma en cualquier instante de la curva de crecimiento en el que se encuentre el microorganismo.');
 

insert into Respuestas VALUES (5,'A',1,'Tu respuesta es correcta','La formaci�n de enlaces covalentes entre restos de pirimidina adyacentes en una misma cadena.');
insert into Respuestas VALUES (5,'B',0,'Produce <B> cambios qu�micos </B> en la bacteria.','Cambios f�sicos en la bacteria.');
insert into Respuestas VALUES (5,'C',0,'La enzima encargada de la replicaci�n es la <B>DNA polimerasa.','Un bloqueo parcial de la replicaci�n a cargo de la enzima denominada DNA helicasa.');


insert into Respuestas VALUES (6,'A',0,'Si una c�lula de <I>EscherichiaColi</I> pierde el gen que codifica el enzima &#223-glactosidasa, <B>cambia el fenotipo </B>.','Si una c�lula de <I>EscherichiaColi</I> pierde el gen que codifica el enzima &#223-glactosidasa, no cambia el fenotipo.');
insert into Respuestas VALUES (6,'B',1,'Tu respuesta es correcta','Si una c�lula de <I>EscherichiaColi</I> pierde el gen que codifica el enzima &#223-glactosidasa, cambia el genotipo.');
insert into Respuestas VALUES (6,'C',0,'Si una c�lula de <I>EscherichiaColi</I> pierde el gen que codifica el enzima &#223-glactosidasa, <B>no es capaz de metabolizar la lactosa</B>.','Si una c�lula de <I>EscherichiaColi</I> pierde el gen que codifica el enzima &#223-glactosidasa, es capaz de metabolizar la lactosa.');

insert into Respuestas VALUES (7,'A',0,'El mRNA  no tiene timina, sino uracilo.','IMAGENES/Respuesta7A.jpg');
insert into Respuestas VALUES (7,'B',1,'Debido a la luz ultravioleta se forma un d�mero de timina, que al ser reparada por la DNA polimerasa causa una mutaci�n e introduce una adenina en lugar de una timina. La cadena complementaria cambia el orden de sus nucle�tidos y al transcribirse al mRNA queda de la siguiente forma:','IMAGENES/Respuesta7B.jpg');
insert into Respuestas VALUES (7,'C',0,'La sexta base nitrogenada de la cadena tendr�a que ser una G. Y por otra parte, si sufre una mutaci�n con luz UV se produce un d�mero de timina y por tanto no podr�an aparecer dos uracilos en las posiciones 8 y 9 de la cadena mRNA.','IMAGENES/Respuesta7A.jpg');


insert into Respuestas VALUES (8,'A',0,'La prote�na se empieza a sintetizar a partir del <B>cod�n de inicio AUG</B> que codifica el amino�cido metionina, no con el primer cod�n que aparece en el mRNA.','Ser-Cis-Ala-Ala-Asp-Tre-Ser-Glu-Ala-Asn');
insert into Respuestas VALUES (8,'B',0,'La prote�na se empieza a sintetizar a partir del <B>cod�n de inicio AUG</B>  que codifica el amino�cido metionina. No se puede empezar a sintetizar a partir de cualquier base nitrogenada. ','Ala-Ala-Asp-Tre-Ser-Glu-Arg-Asn');
insert into Respuestas VALUES (8,'C',1,'Tu respuesta es correcta','Met-Arg-Ser-Arg-Tir-Glu-Ser-Gli');


insert into Respuestas VALUES (9,'A',0,'S�lo act�a <B>in vivo</B>.','La nitrosoguanidina NTG es un mut�geno que act�a tanto in vivo como in vitro.');
insert into Respuestas VALUES (9,'B',0,'Su efecto lo ejerce sobre la horquilla de replicaci�n del DNA.','La nitrosoguanidina NTG es un mut�geno que act�a en el proceso de traducci�n a prote�nas.');
insert into Respuestas VALUES (9,'C',1,'Tu respuesta es correcta','La nitrosoguanidina NTG es un mut�geno que induce una reparaci�n SOS propensa a error, dando origen a transiciones del marco original de lectura.');


insert into Respuestas VALUES (10,'A',1,'Son secuencias de DNA que se transladan de una parte a otra del genoma, por eso, se denominan elementos transponibles o genes saltarines.','Porque son secuencias de DNA que causan mutaciones mediante transposici�n.');
insert into Respuestas VALUES (10,'B',0,'Se mueven de un lado a otro del <b>genoma</b>. ','Porque saltan de una c�lula a otra.');
insert into Respuestas VALUES (10,'C',0,'Son secuencias de DNA que forman mutaciones por <b>transposici�n</b>.','Porque forman mutaciones por deleci�n de un trozo de la cadena de DNA.');





