#light "off"
module FStar_List_Pure_Base

let rec map2 = (fun ( f  :  'a1  ->  'a2  ->  'b ) ( l1  :  'a1 Prims.list ) ( l2  :  'a2 Prims.list ) -> (match (((l1), (l2))) with
| ([], []) -> begin
[]
end
| ((x1)::xs1, (x2)::xs2) -> begin
((f x1 x2))::(map2 f xs1 xs2)
end))


let rec map3 = (fun ( f  :  'a1  ->  'a2  ->  'a3  ->  'b ) ( l1  :  'a1 Prims.list ) ( l2  :  'a2 Prims.list ) ( l3  :  'a3 Prims.list ) -> (match (((l1), (l2), (l3))) with
| ([], [], []) -> begin
[]
end
| ((x1)::xs1, (x2)::xs2, (x3)::xs3) -> begin
((f x1 x2 x3))::(map3 f xs1 xs2 xs3)
end))


let zip = (fun ( l1  :  'a1 Prims.list ) ( l2  :  'a2 Prims.list ) -> (map2 (fun ( x  :  'a1 ) ( y  :  'a2 ) -> ((x), (y))) l1 l2))


let zip3 = (fun ( l1  :  'a1 Prims.list ) ( l2  :  'a2 Prims.list ) ( l3  :  'a3 Prims.list ) -> (map3 (fun ( x  :  'a1 ) ( y  :  'a2 ) ( z  :  'a3 ) -> ((x), (y), (z))) l1 l2 l3))




