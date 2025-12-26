#light "off"
module FStar_OrdSetProps

let rec fold = (fun ( f  :  'a FStar_OrdSet.cmp ) ( g  :  'a  ->  'b  ->  'b ) ( s  :  ('a, obj) FStar_OrdSet.ordset ) ( x  :  'b ) -> (match ((Prims.op_Equality s (FStar_OrdSet.empty f))) with
| true -> begin
x
end
| uu___ -> begin
(

let uu___1 = (FStar_OrdSet.choose f s)
in (match (uu___1) with
| FStar_Pervasives_Native.Some (e) -> begin
(

let a_rest = (fold f g (FStar_OrdSet.remove f e s) x)
in (g e a_rest))
end))
end))


let insert = (fun ( f  :  'a FStar_OrdSet.cmp ) ( x  :  'a ) ( s  :  ('a, obj) FStar_OrdSet.ordset ) -> (FStar_OrdSet.union f (FStar_OrdSet.singleton f x) s))


let union' = (fun ( f  :  'a FStar_OrdSet.cmp ) ( s1  :  ('a, obj) FStar_OrdSet.ordset ) ( s2  :  ('a, obj) FStar_OrdSet.ordset ) -> (fold f (fun ( e  :  'a ) ( s  :  ('a, obj) FStar_OrdSet.ordset ) -> (insert f e s)) s1 s2))




