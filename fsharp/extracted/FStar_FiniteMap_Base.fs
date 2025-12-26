#light "off"
module FStar_FiniteMap_Base

type ('a, 'b) setfun_t =
('a, 'b FStar_Pervasives_Native.option) FStar_FunctionalExtensionality.restricted_t


type ('a, 'b) map =
('a FStar_FiniteSet_Base.set, ('a, 'b) setfun_t) Prims.dtuple2


let domain = (fun ( m  :  ('a, 'b) map ) -> (

let uu___ = m
in (match (uu___) with
| Prims.Mkdtuple2 (keys, uu___1) -> begin
keys
end)))


let elements = (fun ( m  :  ('a, 'b) map ) -> (

let uu___ = m
in (match (uu___) with
| Prims.Mkdtuple2 (uu___1, f) -> begin
f
end)))


let mem = (fun ( key  :  'a ) ( m  :  ('a, 'b) map ) -> (FStar_FiniteSet_Base.mem key (domain m)))


let rec key_in_item_list = (fun ( key  :  'a ) ( items  :  ('a * 'b) Prims.list ) -> (match (items) with
| [] -> begin
false
end
| ((k, v))::tl -> begin
((Prims.op_Equality key k) || (key_in_item_list key tl))
end))


let rec item_list_doesnt_repeat_keys = (fun ( items  :  ('a * 'b) Prims.list ) -> (match (items) with
| [] -> begin
true
end
| ((k, v))::tl -> begin
((not ((key_in_item_list k tl))) && (item_list_doesnt_repeat_keys tl))
end))


let lookup = (fun ( key  :  'a ) ( m  :  ('a, 'b) map ) -> (FStar_Pervasives_Native.__proj__Some__item__v (elements m key)))




let emptymap = (fun ( uu___  :  unit ) -> Prims.Mkdtuple2 ((FStar_FiniteSet_Base.emptyset ()), (FStar_FunctionalExtensionality.on_domain (fun ( key  :  'a ) -> FStar_Pervasives_Native.None))))


let glue = (fun ( keys  :  'a FStar_FiniteSet_Base.set ) ( f  :  ('a, 'b) setfun_t ) -> Prims.Mkdtuple2 (keys, f))


let insert = (fun ( k  :  'a ) ( v  :  'b ) ( m  :  ('a, 'b) map ) -> (

let keys' = (FStar_FiniteSet_Base.insert k (domain m))
in (

let f' = (FStar_FunctionalExtensionality.on_domain (fun ( key  :  'a ) -> (match ((Prims.op_Equality key k)) with
| true -> begin
FStar_Pervasives_Native.Some (v)
end
| uu___ -> begin
(elements m key)
end)))
in Prims.Mkdtuple2 (keys', f'))))


let merge = (fun ( m1  :  ('a, 'b) map ) ( m2  :  ('a, 'b) map ) -> (

let keys' = (FStar_FiniteSet_Base.union (domain m1) (domain m2))
in (

let f' = (FStar_FunctionalExtensionality.on_domain (fun ( key  :  'a ) -> (match ((FStar_FiniteSet_Base.mem key (domain m2))) with
| true -> begin
(elements m2 key)
end
| uu___ -> begin
(elements m1 key)
end)))
in Prims.Mkdtuple2 (keys', f'))))


let subtract = (fun ( m  :  ('a, 'b) map ) ( s  :  'a FStar_FiniteSet_Base.set ) -> (

let keys' = (FStar_FiniteSet_Base.difference (domain m) s)
in (

let f' = (FStar_FunctionalExtensionality.on_domain (fun ( key  :  'a ) -> (match ((FStar_FiniteSet_Base.mem key keys')) with
| true -> begin
(elements m key)
end
| uu___ -> begin
FStar_Pervasives_Native.None
end)))
in Prims.Mkdtuple2 (keys', f'))))




let remove = (fun ( key  :  'a ) ( m  :  ('a, 'b) map ) -> (subtract m (FStar_FiniteSet_Base.singleton key)))


let notin = (fun ( key  :  'a ) ( m  :  ('a, 'b) map ) -> (not ((mem key m))))


type cardinality_zero_iff_empty_fact =
unit


type empty_or_domain_occupied_fact =
unit


type empty_or_values_occupied_fact =
unit


type empty_or_items_occupied_fact =
unit


type map_cardinality_matches_domain_fact =
unit


type values_contains_fact =
unit


type items_contains_fact =
unit


type empty_domain_empty_fact =
unit


type glue_domain_fact =
unit


type glue_elements_fact =
unit


type insert_elements_fact =
unit


type insert_member_cardinality_fact =
unit


type insert_nonmember_cardinality_fact =
unit


type merge_domain_is_union_fact =
unit


type merge_element_fact =
unit


type subtract_domain_fact =
unit


type subtract_element_fact =
unit


type map_equal_fact =
unit


type map_extensionality_fact =
unit


type disjoint_fact =
unit


type all_finite_map_facts =
unit




