#light "off"
module FStar_Fin

type fin =
Prims.int


type under =
Prims.nat


type 'a vect =
'a Prims.list


type 'a seqn =
'a FStar_Seq_Base.seq


type in_ =
Prims.nat


let rec find = (fun ( s  :  'a FStar_Seq_Base.seq ) ( p  :  'a  ->  Prims.bool ) ( i  :  Prims.nat ) -> (match ((p (FStar_Seq_Base.index s i))) with
| true -> begin
FStar_Pervasives_Native.Some (i)
end
| uu___ -> begin
(match (((i + (Prims.parse_int "1")) < (FStar_Seq_Base.length s))) with
| true -> begin
(find s p (i + (Prims.parse_int "1")))
end
| uu___1 -> begin
FStar_Pervasives_Native.None
end)
end))


let rec pigeonhole : Prims.pos  ->  Prims.nat FStar_Seq_Base.seq  ->  (Prims.nat * Prims.nat) = (fun ( n  :  Prims.pos ) ( s  :  Prims.nat FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality n (Prims.parse_int "1"))) with
| true -> begin
(((Prims.parse_int "0")), ((Prims.parse_int "1")))
end
| uu___ -> begin
(

let k0 = (FStar_Seq_Base.index s (Prims.parse_int "0"))
in (match ((find s (fun ( k  :  Prims.nat ) -> (Prims.op_Equality k k0)) (Prims.parse_int "1"))) with
| FStar_Pervasives_Native.Some (i) -> begin
(((Prims.parse_int "0")), (i))
end
| FStar_Pervasives_Native.None -> begin
(

let uu___1 = (pigeonhole (n - (Prims.parse_int "1")) (FStar_Seq_Base.init n (fun ( i  :  Prims.nat ) -> (

let k = (FStar_Seq_Base.index s (i + (Prims.parse_int "1")))
in (match ((k < k0)) with
| true -> begin
k
end
| uu___2 -> begin
(k - (Prims.parse_int "1"))
end)))))
in (match (uu___1) with
| (i1, i2) -> begin
(((i1 + (Prims.parse_int "1"))), ((i2 + (Prims.parse_int "1"))))
end))
end))
end))


type 'a binary_relation =
'a  ->  'a  ->  Prims.bool





type 'a equivalence_relation =
'a  ->  'a  ->  Prims.bool


type contains_eq =
unit


type 'a items_of =
'a


let rec find_eq = (fun ( eq  :  'a equivalence_relation ) ( s  :  'a FStar_Seq_Base.seq ) ( x  :  'a ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "1"))) with
| true -> begin
(Prims.parse_int "0")
end
| uu___ -> begin
(match ((eq x (FStar_Seq_Base.index s (Prims.parse_int "0")))) with
| true -> begin
(Prims.parse_int "0")
end
| uu___1 -> begin
(

let ieq = (find_eq eq (FStar_Seq_Properties.tail s) x)
in ((Prims.parse_int "1") + ieq))
end)
end))


let rec pigeonhole_eq = (fun ( eq  :  'a equivalence_relation ) ( holes  :  'a FStar_Seq_Base.seq ) ( pigeons  :  'a items_of FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length holes) (Prims.parse_int "1"))) with
| true -> begin
(((Prims.parse_int "0")), ((Prims.parse_int "1")))
end
| uu___ -> begin
(

let first_pigeon = (FStar_Seq_Base.index pigeons (Prims.parse_int "0"))
in (match ((find pigeons (eq first_pigeon) (Prims.parse_int "1"))) with
| FStar_Pervasives_Native.Some (i) -> begin
(((Prims.parse_int "0")), (i))
end
| FStar_Pervasives_Native.None -> begin
(

let index_of_first_pigeon = (find_eq eq holes first_pigeon)
in (

let holes_except_first_pigeon = (FStar_Seq_Base.append (FStar_Seq_Base.slice holes (Prims.parse_int "0") index_of_first_pigeon) (FStar_Seq_Base.slice holes (index_of_first_pigeon + (Prims.parse_int "1")) (FStar_Seq_Base.length holes)))
in (

let uu___1 = (pigeonhole_eq eq holes_except_first_pigeon (FStar_Seq_Base.init ((FStar_Seq_Base.length pigeons) - (Prims.parse_int "1")) (fun ( i  :  Prims.nat ) -> (FStar_Seq_Base.index pigeons (i + (Prims.parse_int "1"))))))
in (match (uu___1) with
| (i1, i2) -> begin
(((i1 + (Prims.parse_int "1"))), ((i2 + (Prims.parse_int "1"))))
end))))
end))
end))




