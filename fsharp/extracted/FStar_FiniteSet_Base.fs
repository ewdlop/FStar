#light "off"
module FStar_FiniteSet_Base

type has_elements =
unit


type 'a set =
('a, Prims.bool) FStar_FunctionalExtensionality.restricted_t


let mem = (fun ( x  :  'a ) ( s  :  'a set ) -> (s x))


let rec list_nonrepeating = (fun ( xs  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
true
end
| (hd)::tl -> begin
((not ((FStar_List_Tot_Base.mem hd tl))) && (list_nonrepeating tl))
end))


let rec remove_repeats = (fun ( xs  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
[]
end
| (hd)::tl -> begin
(

let tl' = (remove_repeats tl)
in (match ((FStar_List_Tot_Base.mem hd tl)) with
| true -> begin
tl'
end
| uu___ -> begin
(hd)::tl'
end))
end))


let intro_set = (fun ( f  :  ('a, Prims.bool) FStar_FunctionalExtensionality.restricted_t ) ( xs  :  unit ) -> f)


let emptyset = (fun ( uu___  :  unit ) -> (intro_set (FStar_FunctionalExtensionality.on_domain (fun ( uu___1  :  'a ) -> false)) ()))


let insert = (fun ( x  :  'a ) ( s  :  'a set ) -> (intro_set (FStar_FunctionalExtensionality.on_domain (fun ( x'  :  'a ) -> ((Prims.op_Equality x x') || (s x')))) ()))


let singleton = (fun ( x  :  'a ) -> (insert x (emptyset ())))


let rec union_lists = (fun ( xs  :  'a Prims.list ) ( ys  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
ys
end
| (hd)::tl -> begin
(hd)::(union_lists tl ys)
end))


let union = (fun ( s1  :  'a set ) ( s2  :  'a set ) -> (intro_set (FStar_FunctionalExtensionality.on_domain (fun ( x  :  'a ) -> ((s1 x) || (s2 x)))) ()))


let rec intersect_lists = (fun ( xs  :  'a Prims.list ) ( ys  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
[]
end
| (hd)::tl -> begin
(

let zs' = (intersect_lists tl ys)
in (match ((FStar_List_Tot_Base.mem hd ys)) with
| true -> begin
(hd)::zs'
end
| uu___ -> begin
zs'
end))
end))


let intersection = (fun ( s1  :  'a set ) ( s2  :  'a set ) -> (intro_set (FStar_FunctionalExtensionality.on_domain (fun ( x  :  'a ) -> ((s1 x) && (s2 x)))) ()))


let rec difference_lists = (fun ( xs  :  'a Prims.list ) ( ys  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
[]
end
| (hd)::tl -> begin
(

let zs' = (difference_lists tl ys)
in (match ((FStar_List_Tot_Base.mem hd ys)) with
| true -> begin
zs'
end
| uu___ -> begin
(hd)::zs'
end))
end))


let difference = (fun ( s1  :  'a set ) ( s2  :  'a set ) -> (intro_set (FStar_FunctionalExtensionality.on_domain (fun ( x  :  'a ) -> ((s1 x) && (not ((s2 x)))))) ()))





let remove = (fun ( x  :  'a ) ( s  :  'a set ) -> (difference s (singleton x)))


let notin = (fun ( x  :  'a ) ( s  :  'a set ) -> (not ((mem x s))))


type empty_set_contains_no_elements_fact =
unit


type length_zero_fact =
unit


type singleton_contains_argument_fact =
unit


type singleton_contains_fact =
unit


type singleton_cardinality_fact =
unit


type insert_fact =
unit


type insert_contains_argument_fact =
unit


type insert_contains_fact =
unit


type insert_member_cardinality_fact =
unit


type insert_nonmember_cardinality_fact =
unit


type union_contains_fact =
unit


type union_contains_element_from_first_argument_fact =
unit


type union_contains_element_from_second_argument_fact =
unit


type union_of_disjoint_fact =
unit


type intersection_contains_fact =
unit


type union_idempotent_right_fact =
unit


type union_idempotent_left_fact =
unit


type intersection_idempotent_right_fact =
unit


type intersection_idempotent_left_fact =
unit


type intersection_cardinality_fact =
unit


type difference_contains_fact =
unit


type difference_doesnt_include_fact =
unit


type difference_cardinality_fact =
unit


type subset_fact =
unit


type equal_fact =
unit


type equal_extensionality_fact =
unit


type disjoint_fact =
unit


type insert_remove_fact =
unit


type remove_insert_fact =
unit


type set_as_list_cardinality_fact =
unit


type all_finite_set_facts =
unit


let rec remove_from_nonrepeating_list = (fun ( x  :  'a ) ( xs  :  'a Prims.list ) -> (match (xs) with
| (hd)::tl -> begin
(match ((Prims.op_Equality x hd)) with
| true -> begin
tl
end
| uu___ -> begin
(hd)::(remove_from_nonrepeating_list x tl)
end)
end))




