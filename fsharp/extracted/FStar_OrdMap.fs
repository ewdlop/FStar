#light "off"
module FStar_OrdMap

type total_order =
unit


type 'a cmp =
'a  ->  'a  ->  Prims.bool


type ('k, 'v) map_t =
('k, 'v FStar_Pervasives_Native.option) FStar_FunctionalExtensionality.restricted_t

type ('k, 'v, 'f) ordmap =
| Mk_map of ('k, 'f) FStar_OrdSet.ordset * ('k, 'v) map_t


let uu___is_Mk_map = (fun ( f  :  'k FStar_OrdSet.cmp ) ( projectee  :  ('k, 'v, obj) ordmap ) -> true)


let __proj__Mk_map__item__d = (fun ( f  :  'k FStar_OrdSet.cmp ) ( projectee  :  ('k, 'v, obj) ordmap ) -> (match (projectee) with
| Mk_map (d, m) -> begin
d
end))


let __proj__Mk_map__item__m = (fun ( f  :  'k FStar_OrdSet.cmp ) ( projectee  :  ('k, 'v, obj) ordmap ) -> (match (projectee) with
| Mk_map (d, m) -> begin
m
end))


let empty = (fun ( f  :  'k FStar_OrdSet.cmp ) -> (

let d = (FStar_OrdSet.empty f)
in (

let g = (FStar_FunctionalExtensionality.on_domain (fun ( x  :  'k ) -> FStar_Pervasives_Native.None))
in Mk_map (d, g))))


let const_on = (fun ( f  :  'k FStar_OrdSet.cmp ) ( d  :  ('k, obj) FStar_OrdSet.ordset ) ( x  :  'v ) -> (

let g = (FStar_FunctionalExtensionality.on_domain (fun ( y  :  'k ) -> (match ((FStar_OrdSet.mem f y d)) with
| true -> begin
FStar_Pervasives_Native.Some (x)
end
| uu___ -> begin
FStar_Pervasives_Native.None
end)))
in Mk_map (d, g)))


let select1 = (fun ( f  :  'k FStar_OrdSet.cmp ) ( x  :  'k ) ( m  :  ('k, 'v, obj) ordmap ) -> (__proj__Mk_map__item__m f m x))


let insert = (fun ( f  :  'a FStar_OrdSet.cmp ) ( x  :  'a ) ( s  :  ('a, obj) FStar_OrdSet.ordset ) -> (FStar_OrdSet.union f (FStar_OrdSet.singleton f x) s))


let update = (fun ( f  :  'k FStar_OrdSet.cmp ) ( x  :  'k ) ( y  :  'v ) ( m  :  ('k, 'v, obj) ordmap ) -> (

let s' = (insert f x (__proj__Mk_map__item__d f m))
in (

let g' = (FStar_FunctionalExtensionality.on_domain (fun ( x'  :  'k ) -> (match ((Prims.op_Equality x' x)) with
| true -> begin
FStar_Pervasives_Native.Some (y)
end
| uu___ -> begin
(__proj__Mk_map__item__m f m x')
end)))
in Mk_map (s', g'))))


let contains = (fun ( f  :  'k FStar_OrdSet.cmp ) ( x  :  'k ) ( m  :  ('k, 'v, obj) ordmap ) -> (FStar_OrdSet.mem f x (__proj__Mk_map__item__d f m)))


let dom = (fun ( f  :  'k FStar_OrdSet.cmp ) ( m  :  ('k, 'v, obj) ordmap ) -> (__proj__Mk_map__item__d f m))


let remove = (fun ( f  :  'k FStar_OrdSet.cmp ) ( x  :  'k ) ( m  :  ('k, 'v, obj) ordmap ) -> (

let s' = (FStar_OrdSet.remove f x (__proj__Mk_map__item__d f m))
in (

let g' = (FStar_FunctionalExtensionality.on_domain (fun ( x'  :  'k ) -> (match ((Prims.op_Equality x' x)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___ -> begin
(__proj__Mk_map__item__m f m x')
end)))
in Mk_map (s', g'))))


let choose = (fun ( f  :  'k FStar_OrdSet.cmp ) ( m  :  ('k, 'v, obj) ordmap ) -> (match ((FStar_OrdSet.choose f (__proj__Mk_map__item__d f m))) with
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.None
end
| FStar_Pervasives_Native.Some (x) -> begin
FStar_Pervasives_Native.Some (((x), ((FStar_Pervasives_Native.__proj__Some__item__v (__proj__Mk_map__item__m f m x)))))
end))


let size = (fun ( f  :  'k FStar_OrdSet.cmp ) ( m  :  ('k, 'v, obj) ordmap ) -> (FStar_OrdSet.size f (__proj__Mk_map__item__d f m)))





