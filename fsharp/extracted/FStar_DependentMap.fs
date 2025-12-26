#light "off"
module FStar_DependentMap
type ('key, 'value) t =
{mappings : ('key, 'value) FStar_FunctionalExtensionality.restricted_t}


let __proj__Mkt__item__mappings = (fun ( projectee  :  ('key, 'value) t ) -> (match (projectee) with
| {mappings = mappings} -> begin
mappings
end))


let create = (fun ( f  :  'key  ->  'value ) -> {mappings = (FStar_FunctionalExtensionality.on_domain f)})


let sel = (fun ( m  :  ('key, 'value) t ) ( k  :  'key ) -> (m.mappings k))


let upd = (fun ( m  :  ('key, 'value) t ) ( k  :  'key ) ( v  :  'value ) -> {mappings = (FStar_FunctionalExtensionality.on_domain (fun ( k'  :  'key ) -> (match ((Prims.op_Equality k' k)) with
| true -> begin
v
end
| uu___ -> begin
(m.mappings k')
end)))})



let restrict = (fun ( m  :  ('key, 'value) t ) -> {mappings = (FStar_FunctionalExtensionality.on_domain m.mappings)})


type concat_value =
obj


let concat_mappings = (fun ( m1  :  'key1  ->  'value1 ) ( m2  :  'key2  ->  'value2 ) ( k  :  ('key1, 'key2) FStar_Pervasives.either ) -> (match (k) with
| FStar_Pervasives.Inl (k1) -> begin
(box (m1 k1))
end
| FStar_Pervasives.Inr (k2) -> begin
(box (m2 k2))
end))


let concat = (fun ( m1  :  ('key1, 'value1) t ) ( m2  :  ('key2, 'value2) t ) -> {mappings = (FStar_FunctionalExtensionality.on_domain (concat_mappings m1.mappings m2.mappings))})


type 'value1 rename_value =
'value1


let rename = (fun ( m  :  ('key1, 'value1) t ) ( key2  :  unit ) ( ren  :  obj  ->  'key1 ) -> {mappings = (FStar_FunctionalExtensionality.on_domain (fun ( k2  :  obj ) -> (m.mappings (ren k2))))})


let map = (fun ( f  :  'key  ->  'value1  ->  'value2 ) ( m  :  ('key, 'value1) t ) -> {mappings = (FStar_FunctionalExtensionality.on_domain (fun ( k  :  'key ) -> (f k (sel m k))))})




