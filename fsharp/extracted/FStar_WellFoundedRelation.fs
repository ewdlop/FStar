#light "off"
module FStar_WellFoundedRelation
type ('a, 'r, 'x) acc_classical =
| AccClassicalIntro of ('a  ->  ('a, 'r, obj) acc_classical)


let uu___is_AccClassicalIntro = (fun ( x  :  'a ) ( projectee  :  ('a, 'r, obj) acc_classical ) -> true)


let __proj__AccClassicalIntro__item__access_smaller = (fun ( x  :  'a ) ( projectee  :  ('a, 'r, obj) acc_classical ) -> (match (projectee) with
| AccClassicalIntro (access_smaller) -> begin
access_smaller
end))

type 'a wfr_t =
{relation : unit; decreaser : 'a  ->  ('a, obj, obj) acc_classical; proof : unit}


let __proj__Mkwfr_t__item__decreaser = (fun ( projectee  :  'a wfr_t ) -> (match (projectee) with
| {relation = relation; decreaser = decreaser; proof = proof} -> begin
decreaser
end))


type ('a, 'x1, 'x2) default_relation =
('a, 'a, 'x1, 'x2) Prims.precedes


let rec default_decreaser = (fun ( x  :  'a ) -> (

let smaller = (fun ( y  :  'a ) -> (default_decreaser y))
in AccClassicalIntro (smaller)))


let default_wfr = (fun ( uu___  :  unit ) -> {relation = (); decreaser = (fun ( uu___1  :  'a ) -> ((Prims.unsafe_coerce default_decreaser) uu___1)); proof = ()})


type empty_relation =
unit


let rec empty_decreaser = (fun ( x  :  'a ) -> (

let smaller = (fun ( y  :  'a ) -> (empty_decreaser y))
in AccClassicalIntro (smaller)))


let empty_wfr = (fun ( uu___  :  unit ) -> {relation = (); decreaser = (fun ( uu___1  :  'a ) -> ((Prims.unsafe_coerce empty_decreaser) uu___1)); proof = ()})


type acc_relation =
unit


let rec acc_decreaser = (fun ( f  :  unit ) ( x  :  'a ) -> (

let smaller = (fun ( y  :  'a ) -> (acc_decreaser () y))
in AccClassicalIntro (smaller)))


let acc_to_wfr = (fun ( f  :  unit ) -> {relation = (); decreaser = (fun ( uu___  :  'a ) -> ((Prims.unsafe_coerce (acc_decreaser ())) uu___)); proof = ()})


let rec subrelation_decreaser = (fun ( wfr  :  'a wfr_t ) ( x  :  'a ) -> (

let smaller = (fun ( y  :  'a ) -> (subrelation_decreaser wfr y))
in AccClassicalIntro (smaller)))


let subrelation_to_wfr = (fun ( wfr  :  'a wfr_t ) -> {relation = (); decreaser = (fun ( uu___  :  'a ) -> ((Prims.unsafe_coerce (subrelation_decreaser wfr)) uu___)); proof = ()})


let rec inverse_image_decreaser = (fun ( f  :  'a  ->  'b ) ( wfr  :  'b wfr_t ) ( x  :  'a ) -> (

let smaller = (fun ( y  :  'a ) -> (inverse_image_decreaser f wfr y))
in AccClassicalIntro (smaller)))


let inverse_image_to_wfr = (fun ( f  :  'a  ->  'b ) ( wfr  :  'b wfr_t ) -> {relation = (); decreaser = (fun ( uu___  :  'a ) -> ((Prims.unsafe_coerce (inverse_image_decreaser f wfr)) uu___)); proof = ()})


type lex_nondep_relation =
obj


let rec lex_nondep_decreaser = (fun ( wfr_a  :  'a wfr_t ) ( wfr_b  :  'b wfr_t ) ( xy  :  ('a * 'b) ) -> (

let smaller = (fun ( xy'  :  ('a * 'b) ) -> (lex_nondep_decreaser wfr_a wfr_b xy'))
in AccClassicalIntro (smaller)))


let lex_nondep_wfr = (fun ( wfr_a  :  'a wfr_t ) ( wfr_b  :  'b wfr_t ) -> {relation = (); decreaser = (lex_nondep_decreaser wfr_a wfr_b); proof = ()})


type lex_dep_relation =
obj


let rec lex_dep_decreaser = (fun ( wfr_a  :  'a wfr_t ) ( a_to_wfr_b  :  'a  ->  'b wfr_t ) ( xy  :  ('a, 'b) Prims.dtuple2 ) -> (

let smaller = (fun ( xy'  :  ('a, 'b) Prims.dtuple2 ) -> (lex_dep_decreaser wfr_a a_to_wfr_b xy'))
in AccClassicalIntro (smaller)))


let lex_dep_wfr = (fun ( wfr_a  :  'a wfr_t ) ( a_to_wfr_b  :  'a  ->  'b wfr_t ) -> {relation = (); decreaser = (lex_dep_decreaser wfr_a a_to_wfr_b); proof = ()})


type bool_relation =
unit


let bool_wfr : Prims.bool wfr_t = (inverse_image_to_wfr (fun ( b  :  Prims.bool ) -> (match (b) with
| true -> begin
(Prims.parse_int "1")
end
| uu___ -> begin
(Prims.parse_int "0")
end)) (default_wfr ()))


type option_relation =
unit


let option_wfr = (fun ( wfr  :  'a wfr_t ) -> (

let f = (fun ( opt  :  'a FStar_Pervasives_Native.option ) -> (match (opt) with
| FStar_Pervasives_Native.Some (x) -> begin
Prims.Mkdtuple2 (true, (Prims.unsafe_coerce x))
end
| FStar_Pervasives_Native.None -> begin
Prims.Mkdtuple2 (false, (Prims.unsafe_coerce (FStar_Universe.raise_val ())))
end))
in (

let bool_to_wfr_a = (fun ( uu___  :  Prims.bool ) -> ((fun ( b  :  Prims.bool ) -> (match (b) with
| true -> begin
(Prims.unsafe_coerce (box wfr))
end
| uu___ -> begin
(Prims.unsafe_coerce (box (empty_wfr ())))
end)) uu___))
in (

let wfr_bool_a = (lex_dep_wfr bool_wfr bool_to_wfr_a)
in (inverse_image_to_wfr f wfr_bool_a)))))




