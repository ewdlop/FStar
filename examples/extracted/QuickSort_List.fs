#light "off"
module QuickSort_List

let rec sorted = (fun ( f  :  'a  ->  'a  ->  Prims.bool ) ( uu___  :  'a Prims.list ) -> (match (uu___) with
| (x)::(y)::xs -> begin
((f x y) && (sorted f ((y)::xs)))
end
| uu___1 -> begin
true
end))


type 'a total_order =
'a  ->  'a  ->  Prims.bool


let rec count = (fun ( x  :  'a ) ( uu___  :  'a Prims.list ) -> (match (uu___) with
| (hd)::tl -> begin
((match ((Prims.op_Equality hd x)) with
| true -> begin
(Prims.parse_int "1")
end
| uu___1 -> begin
(Prims.parse_int "0")
end) + (count x tl))
end
| [] -> begin
(Prims.parse_int "0")
end))


let rec partition = (fun ( f  :  'a  ->  Prims.bool ) ( uu___  :  'a Prims.list ) -> (match (uu___) with
| [] -> begin
(([]), ([]))
end
| (hd)::tl -> begin
(

let uu___1 = (partition f tl)
in (match (uu___1) with
| (l1, l2) -> begin
(match ((f hd)) with
| true -> begin
(((hd)::l1), (l2))
end
| uu___2 -> begin
((l1), ((hd)::l2))
end)
end))
end))


type is_permutation =
unit


let rec quicksort = (fun ( f  :  'a total_order ) ( l  :  'a Prims.list ) -> (match (l) with
| [] -> begin
[]
end
| (pivot)::tl -> begin
(

let uu___ = (partition (f pivot) tl)
in (match (uu___) with
| (hi, lo) -> begin
(

let m = (FStar_List_Tot_Base.op_At (quicksort f lo) ((pivot)::(quicksort f hi)))
in m)
end))
end))




