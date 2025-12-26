#light "off"
module Coincidence

let rec mem : Prims.int  ->  Prims.int Prims.list  ->  Prims.bool = (fun ( a  :  Prims.int ) ( l  :  Prims.int Prims.list ) -> (match (l) with
| [] -> begin
false
end
| (hd)::tl -> begin
((Prims.op_Equality hd a) || (mem a tl))
end))


let rec sorted : Prims.int Prims.list  ->  Prims.bool = (fun ( l  :  Prims.int Prims.list ) -> (match (l) with
| (x)::(y)::xs -> begin
((x < y) && (sorted ((y)::xs)))
end
| uu___ -> begin
true
end))


let rec coincidence : Prims.int Prims.list  ->  Prims.int Prims.list  ->  Prims.int Prims.list = (fun ( xs  :  Prims.int Prims.list ) ( ys  :  Prims.int Prims.list ) -> (match (((xs), (ys))) with
| ((x)::xs', (y)::ys') -> begin
(match ((Prims.op_Equality x y)) with
| true -> begin
(x)::(coincidence xs' ys')
end
| uu___ -> begin
(match ((x < y)) with
| true -> begin
(coincidence xs' ys)
end
| uu___1 -> begin
(coincidence xs ys')
end)
end)
end
| uu___ -> begin
[]
end))




