#light "off"
module FStar_Sequence_Util

let slice = (fun ( s  :  'ty FStar_Sequence_Base.seq ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) -> (FStar_Sequence_Base.drop (FStar_Sequence_Base.take s j) i))


let cons = (fun ( x  :  'a ) ( s  :  'a FStar_Sequence_Base.seq ) -> (FStar_Sequence_Base.append (FStar_Sequence_Base.singleton x) s))


let head = (fun ( s  :  'a FStar_Sequence_Base.seq ) -> ((FStar_Sequence_Base.op_Dollar_At ()) s (Prims.parse_int "0")))


let tail = (fun ( s  :  'a FStar_Sequence_Base.seq ) -> (FStar_Sequence_Base.drop s (Prims.parse_int "1")))


let un_build = (fun ( s  :  'a FStar_Sequence_Base.seq ) -> (((FStar_Sequence_Base.take s ((FStar_Sequence_Base.length s) - (Prims.parse_int "1")))), (((FStar_Sequence_Base.op_Dollar_At ()) s ((FStar_Sequence_Base.length s) - (Prims.parse_int "1"))))))


let split = (fun ( s  :  'a FStar_Sequence_Base.seq ) ( i  :  Prims.nat ) -> (((FStar_Sequence_Base.take s i)), ((FStar_Sequence_Base.drop s i))))


let rec count_matches = (fun ( f  :  'a  ->  Prims.bool ) ( s  :  'a FStar_Sequence_Base.seq ) -> (match ((Prims.op_Equality (FStar_Sequence_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(Prims.parse_int "0")
end
| uu___ -> begin
(match ((f (head s))) with
| true -> begin
((Prims.parse_int "1") + (count_matches f (tail s)))
end
| uu___1 -> begin
(count_matches f (tail s))
end)
end))


let count = (fun ( x  :  'a ) ( s  :  'a FStar_Sequence_Base.seq ) -> (count_matches (fun ( y  :  'a ) -> (Prims.op_Equality x y)) s))


let rec fold_back = (fun ( f  :  'b  ->  'a  ->  'a ) ( s  :  'b FStar_Sequence_Base.seq ) ( init  :  'a ) -> (match ((Prims.op_Equality (FStar_Sequence_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
init
end
| uu___ -> begin
(

let last = ((FStar_Sequence_Base.op_Dollar_At ()) s ((FStar_Sequence_Base.length s) - (Prims.parse_int "1")))
in (

let s1 = (FStar_Sequence_Base.take s ((FStar_Sequence_Base.length s) - (Prims.parse_int "1")))
in (f last (fold_back f s1 init))))
end))




