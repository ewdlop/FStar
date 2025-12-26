#light "off"
module QuickSort_Array

type partition_inv =
unit


type partition_pre =
unit


type partition_post =
unit


let rec partition = (fun ( f  :  'a FStar_Seq_Properties.tot_ord ) ( start  :  Prims.nat ) ( len  :  Prims.nat ) ( pivot  :  Prims.nat ) ( back  :  Prims.nat ) ( x  :  'a FStar_Array.array ) -> (

let h0 = (FStar_ST.get ())
in (match ((Prims.op_Equality pivot back)) with
| true -> begin
pivot
end
| uu___ -> begin
(

let next = (FStar_Array.index x (pivot + (Prims.parse_int "1")))
in (

let p = (FStar_Array.index x pivot)
in (match ((f next p)) with
| true -> begin
((FStar_Array.swap x pivot (pivot + (Prims.parse_int "1")));
(

let h1 = (FStar_ST.get ())
in (

let res = (partition f start len (pivot + (Prims.parse_int "1")) back x)
in (

let h2 = (FStar_ST.get ())
in res)));
)
end
| uu___1 -> begin
((FStar_Array.swap x (pivot + (Prims.parse_int "1")) back);
(

let h1 = (FStar_ST.get ())
in (

let res = (partition f start len pivot (back - (Prims.parse_int "1")) x)
in (

let h2 = (FStar_ST.get ())
in res)));
)
end)))
end)))


let rec sort = (fun ( f  :  'a FStar_Seq_Properties.tot_ord ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) ( x  :  'a FStar_Array.array ) -> (

let h0 = (FStar_ST.get ())
in (match ((Prims.op_Equality i j)) with
| true -> begin
()
end
| uu___ -> begin
(

let pivot = (partition f i j i (j - (Prims.parse_int "1")) x)
in (

let h1 = (FStar_ST.get ())
in ((sort f i pivot x);
(

let h2 = (FStar_ST.get ())
in ((sort f (pivot + (Prims.parse_int "1")) j x);
(

let h3 = (FStar_ST.get ())
in ());
));
)))
end)))


let qsort = (fun ( f  :  'a FStar_Seq_Properties.tot_ord ) ( x  :  'a FStar_Array.array ) -> (

let h0 = (FStar_ST.get ())
in (

let len = (FStar_Array.length x)
in ((sort f (Prims.parse_int "0") len x);
(

let h1 = (FStar_ST.get ())
in ());
))))




