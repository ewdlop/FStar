#light "off"
module MergeSort

type split_inv =
unit


let rec split : Prims.int Prims.list  ->  (Prims.int Prims.list * Prims.int Prims.list) = (fun ( uu___  :  Prims.int Prims.list ) -> (match (uu___) with
| (x)::(y)::l -> begin
(match (l) with
| [] -> begin
(((x)::[]), ((y)::[]))
end
| (x')::[] -> begin
(((x)::(x')::[]), ((y)::[]))
end
| uu___1 -> begin
(

let uu___2 = (split l)
in (match (uu___2) with
| (l1, l2) -> begin
(((x)::l1), ((y)::l2))
end))
end)
end))


type merge_inv =
unit


let rec merge : Prims.int Prims.list  ->  Prims.int Prims.list  ->  Prims.int Prims.list = (fun ( l1  :  Prims.int Prims.list ) ( l2  :  Prims.int Prims.list ) -> (match (((l1), (l2))) with
| ([], uu___) -> begin
l2
end
| (uu___, []) -> begin
l1
end
| ((h1)::tl1, (h2)::tl2) -> begin
(match ((h1 <= h2)) with
| true -> begin
(h1)::(merge tl1 l2)
end
| uu___ -> begin
(h2)::(merge l1 tl2)
end)
end))


let rec mergesort : Prims.int Prims.list  ->  Prims.int Prims.list = (fun ( l  :  Prims.int Prims.list ) -> (match (l) with
| [] -> begin
[]
end
| (x)::[] -> begin
(x)::[]
end
| uu___ -> begin
(

let uu___1 = (split l)
in (match (uu___1) with
| (l1, l2) -> begin
(

let sl1 = (mergesort l1)
in (

let sl2 = (mergesort l2)
in (merge sl1 sl2)))
end))
end))




