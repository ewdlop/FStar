#light "off"
module MergeSort2

let rec merge' = (fun ( l1  :  'a Prims.list ) ( l2  :  'a Prims.list ) ( k  :  'a  ->  Prims.int ) -> (match (((l1), (l2))) with
| ([], uu___) -> begin
l2
end
| (uu___, []) -> begin
l1
end
| ((h1)::tl1, (h2)::tl2) -> begin
(match (((k h1) <= (k h2))) with
| true -> begin
(h1)::(merge' tl1 l2 k)
end
| uu___ -> begin
(h2)::(merge' l1 tl2 k)
end)
end))


let rec split_n = (fun ( l  :  'a Prims.list ) ( n  :  Prims.nat ) -> (match (l) with
| (hd)::tl -> begin
(match ((Prims.op_Equality n (Prims.parse_int "1"))) with
| true -> begin
(((hd)::[]), (tl))
end
| uu___ -> begin
(

let next = (split_n tl (n - (Prims.parse_int "1")))
in (((hd)::(FStar_Pervasives_Native.fst next)), ((FStar_Pervasives_Native.snd next))))
end)
end))


let split_half = (fun ( l  :  'a Prims.list ) -> (split_n l ((FStar_List_Tot_Base.length l) / (Prims.parse_int "2"))))


let rec mergesort' = (fun ( l  :  'a Prims.list ) ( k  :  'a  ->  Prims.int ) -> (match (l) with
| [] -> begin
l
end
| (uu___)::[] -> begin
l
end
| (uu___)::(uu___1)::uu___2 -> begin
(

let uu___3 = (split_half l)
in (match (uu___3) with
| (splt1, splt2) -> begin
(merge' (mergesort' splt1 k) (mergesort' splt2 k) k)
end))
end))


let mergesort = (fun ( l  :  'a Prims.list ) ( k  :  'a  ->  Prims.int ) -> (mergesort' l k))




