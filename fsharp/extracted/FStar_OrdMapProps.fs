#light "off"
module FStar_OrdMapProps

let rec fold = (fun ( f  :  'k FStar_OrdMap.cmp ) ( g  :  'k  ->  'v  ->  't  ->  't ) ( m  :  ('k, 'v, obj) FStar_OrdMap.ordmap ) ( a  :  't ) -> (match ((Prims.op_Equality (FStar_OrdMap.size f m) (Prims.parse_int "0"))) with
| true -> begin
a
end
| uu___ -> begin
(

let uu___1 = (FStar_OrdMap.choose f m)
in (match (uu___1) with
| FStar_Pervasives_Native.Some (k1, v1) -> begin
(fold f g (FStar_OrdMap.remove f k1 m) (g k1 v1 a))
end))
end))




