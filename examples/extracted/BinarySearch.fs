#light "off"
module BinarySearch

let rec bsearch_rec : Prims.int FStar_Seq_Base.seq  ->  Prims.int  ->  Prims.nat  ->  Prims.int  ->  Prims.nat FStar_Pervasives_Native.option = (fun ( t  :  Prims.int FStar_Seq_Base.seq ) ( a  :  Prims.int ) ( i  :  Prims.nat ) ( j  :  Prims.int ) -> (match ((i > j)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___ -> begin
(

let mid = ((i + j) / (Prims.parse_int "2"))
in (

let b = (FStar_Seq_Base.index t mid)
in (match ((Prims.op_Equality b a)) with
| true -> begin
FStar_Pervasives_Native.Some (mid)
end
| uu___1 -> begin
(match ((b < a)) with
| true -> begin
(bsearch_rec t a (mid + (Prims.parse_int "1")) j)
end
| uu___2 -> begin
(bsearch_rec t a i (mid - (Prims.parse_int "1")))
end)
end)))
end))


let bsearch : Prims.int FStar_Seq_Base.seq  ->  Prims.int  ->  Prims.nat FStar_Pervasives_Native.option = (fun ( t  :  Prims.int FStar_Seq_Base.seq ) ( a  :  Prims.int ) -> (bsearch_rec t a (Prims.parse_int "0") ((FStar_Seq_Base.length t) - (Prims.parse_int "1"))))




