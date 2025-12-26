#light "off"
module QuickSort_Seq

let rec partition = (fun ( f  :  'a  ->  'a  ->  Prims.bool ) ( s  :  'a FStar_Seq_Base.seq ) ( pivot  :  Prims.nat ) ( back  :  Prims.nat ) -> (match ((Prims.op_Equality pivot back)) with
| true -> begin
(

let lo = (FStar_Seq_Base.slice s (Prims.parse_int "0") pivot)
in (

let hi = (FStar_Seq_Base.slice s pivot (FStar_Seq_Base.length s))
in ((lo), (hi))))
end
| uu___ -> begin
(

let next = (FStar_Seq_Base.index s (pivot + (Prims.parse_int "1")))
in (

let p = (FStar_Seq_Base.index s pivot)
in (match ((f next p)) with
| true -> begin
(

let s' = (FStar_Seq_Properties.swap s pivot (pivot + (Prims.parse_int "1")))
in (partition f s' (pivot + (Prims.parse_int "1")) back))
end
| uu___1 -> begin
(

let s' = (FStar_Seq_Properties.swap s (pivot + (Prims.parse_int "1")) back)
in (

let res = (partition f s' pivot (back - (Prims.parse_int "1")))
in res))
end)))
end))


let rec sort = (fun ( f  :  'a  ->  'a  ->  Prims.bool ) ( s  :  'a FStar_Seq_Base.seq ) -> (match (((FStar_Seq_Base.length s) <= (Prims.parse_int "1"))) with
| true -> begin
s
end
| uu___ -> begin
(

let uu___1 = (partition f s (Prims.parse_int "0") ((FStar_Seq_Base.length s) - (Prims.parse_int "1")))
in (match (uu___1) with
| (lo, hi) -> begin
(

let pivot = (FStar_Seq_Properties.head hi)
in (

let hi_tl = (FStar_Seq_Properties.tail hi)
in (

let l = (sort f lo)
in (

let h = (sort f hi_tl)
in (

let result = (FStar_Seq_Base.append l (FStar_Seq_Base.cons pivot h))
in result)))))
end))
end))




