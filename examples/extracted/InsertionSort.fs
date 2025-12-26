#light "off"
module InsertionSort

let rec insert : Prims.int  ->  Prims.int Prims.list  ->  Prims.int Prims.list = (fun ( i  :  Prims.int ) ( l  :  Prims.int Prims.list ) -> (match (l) with
| [] -> begin
(i)::[]
end
| (hd)::tl -> begin
(match ((i <= hd)) with
| true -> begin
(i)::l
end
| uu___ -> begin
(

let i_tl = (insert i tl)
in (

let uu___1 = i_tl
in (match (uu___1) with
| (z)::uu___2 -> begin
(hd)::i_tl
end)))
end)
end))


let rec insert_implicit : Prims.int  ->  Prims.int Prims.list  ->  Prims.int Prims.list = (fun ( i  :  Prims.int ) ( l  :  Prims.int Prims.list ) -> (match (l) with
| [] -> begin
(i)::[]
end
| (hd)::tl -> begin
(match ((i <= hd)) with
| true -> begin
(i)::l
end
| uu___ -> begin
(hd)::(insert_implicit i tl)
end)
end))


let rec sort : Prims.int Prims.list  ->  Prims.int Prims.list = (fun ( l  :  Prims.int Prims.list ) -> (match (l) with
| [] -> begin
[]
end
| (x)::xs -> begin
(insert x (sort xs))
end))




