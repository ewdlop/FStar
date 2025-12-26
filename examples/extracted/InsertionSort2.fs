#light "off"
module InsertionSort2

let rec insert' = (fun ( x  :  'a ) ( l  :  'a Prims.list ) ( k  :  'a  ->  Prims.int ) -> (match (l) with
| [] -> begin
(x)::[]
end
| (hd)::tl -> begin
(match (((k x) <= (k hd))) with
| true -> begin
(x)::l
end
| uu___ -> begin
(hd)::(insert' x tl k)
end)
end))


let rec insertionsort' = (fun ( l  :  'a Prims.list ) ( k  :  'a  ->  Prims.int ) -> (match (l) with
| [] -> begin
l
end
| (uu___)::[] -> begin
l
end
| (hd)::tl -> begin
(insert' hd (insertionsort' tl k) k)
end))


let insertionsort = (fun ( l  :  'a Prims.list ) ( k  :  'a  ->  Prims.int ) -> (insertionsort' l k))




