#light "off"
module FStar_PartialMap

type ('k, 'v) t =
('k, 'v FStar_Pervasives_Native.option) FStar_FunctionalExtensionality.restricted_t


let empty = (fun ( uu___  :  unit ) -> (FStar_FunctionalExtensionality.on_domain (fun ( uu___1  :  'uuuuu ) -> FStar_Pervasives_Native.None)))


let literal = (fun ( f  :  'k  ->  'v FStar_Pervasives_Native.option ) -> (FStar_FunctionalExtensionality.on_domain (fun ( x  :  'k ) -> (f x))))


let sel = (fun ( m  :  ('k, 'v) t ) ( x  :  'k ) -> (m x))


let upd = (fun ( m  :  ('k, 'v) t ) ( x  :  'k ) ( y  :  'v ) -> (FStar_FunctionalExtensionality.on_domain (fun ( x1  :  'k ) -> (match ((Prims.op_Equality x1 x)) with
| true -> begin
FStar_Pervasives_Native.Some (y)
end
| uu___ -> begin
(m x1)
end))))


let remove = (fun ( m  :  ('k, 'v) t ) ( x  :  'k ) -> (FStar_FunctionalExtensionality.on_domain (fun ( x1  :  'k ) -> (match ((Prims.op_Equality x1 x)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___ -> begin
(m x1)
end))))


let contains = (fun ( m  :  ('k, 'v) t ) ( x  :  'k ) -> (FStar_Pervasives_Native.uu___is_Some (sel m x)))


let const1 = (fun ( y  :  'v ) -> (literal (fun ( x  :  'k ) -> FStar_Pervasives_Native.Some (y))))





