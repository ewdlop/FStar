#light "off"
module Unification

let op_At = (fun ( uu___  :  unit ) -> FStar_List_Tot_Base.append)

type term =
| V of Prims.nat
| F of term * term


let uu___is_V : term  ->  Prims.bool = (fun ( projectee  :  term ) -> (match (projectee) with
| V (i) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__V__item__i : term  ->  Prims.nat = (fun ( projectee  :  term ) -> (match (projectee) with
| V (i) -> begin
i
end))


let uu___is_F : term  ->  Prims.bool = (fun ( projectee  :  term ) -> (match (projectee) with
| F (t1, t2) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__F__item__t1 : term  ->  term = (fun ( projectee  :  term ) -> (match (projectee) with
| F (t1, t2) -> begin
t1
end))


let __proj__F__item__t2 : term  ->  term = (fun ( projectee  :  term ) -> (match (projectee) with
| F (t1, t2) -> begin
t2
end))


let nat_order : Prims.nat FStar_OrdSet.cmp = (fun ( x  :  Prims.nat ) ( y  :  Prims.nat ) -> (x <= y))


type varset =
(Prims.nat, obj) FStar_OrdSet.ordset


let empty_vars : varset = (FStar_OrdSet.empty nat_order)


let rec vars : term  ->  varset = (fun ( uu___  :  term ) -> (match (uu___) with
| V (i) -> begin
(FStar_OrdSet.singleton nat_order i)
end
| F (t1, t2) -> begin
(FStar_OrdSet.union nat_order (vars t1) (vars t2))
end))


type eqns =
(term * term) Prims.list


let rec evars : eqns  ->  varset = (fun ( uu___  :  eqns ) -> (match (uu___) with
| [] -> begin
empty_vars
end
| ((x, y))::tl -> begin
(FStar_OrdSet.union nat_order (FStar_OrdSet.union nat_order (vars x) (vars y)) (evars tl))
end))


let n_evars : eqns  ->  Prims.nat = (fun ( eqns1  :  eqns ) -> (FStar_OrdSet.size nat_order (evars eqns1)))


let rec funs : term  ->  Prims.nat = (fun ( uu___  :  term ) -> (match (uu___) with
| V (uu___1) -> begin
(Prims.parse_int "0")
end
| F (t1, t2) -> begin
(((Prims.parse_int "1") + (funs t1)) + (funs t2))
end))


let rec efuns : eqns  ->  Prims.nat = (fun ( uu___  :  eqns ) -> (match (uu___) with
| [] -> begin
(Prims.parse_int "0")
end
| ((x, y))::tl -> begin
(((funs x) + (funs y)) + (efuns tl))
end))


let rec n_flex_rhs : eqns  ->  Prims.nat = (fun ( uu___  :  eqns ) -> (match (uu___) with
| [] -> begin
(Prims.parse_int "0")
end
| ((V (uu___1), V (uu___2)))::tl -> begin
((Prims.parse_int "1") + (n_flex_rhs tl))
end
| ((uu___1, V (uu___2)))::tl -> begin
((Prims.parse_int "1") + (n_flex_rhs tl))
end
| (uu___1)::tl -> begin
(n_flex_rhs tl)
end))


type subst =
(Prims.nat * term)


type lsubst =
subst Prims.list


let rec subst_term : subst  ->  term  ->  term = (fun ( s  :  subst ) ( t  :  term ) -> (match (t) with
| V (x) -> begin
(match ((Prims.op_Equality x (FStar_Pervasives_Native.fst s))) with
| true -> begin
(FStar_Pervasives_Native.snd s)
end
| uu___ -> begin
V (x)
end)
end
| F (t1, t2) -> begin
F ((subst_term s t1), (subst_term s t2))
end))


let lsubst_term : subst Prims.list  ->  term  ->  term = (FStar_List_Tot_Base.fold_right subst_term)


let occurs : Prims.nat  ->  term  ->  Prims.bool = (fun ( x  :  Prims.nat ) ( t  :  term ) -> (FStar_OrdSet.mem nat_order x (vars t)))


let ok : (Prims.nat * term)  ->  Prims.bool = (fun ( s  :  (Prims.nat * term) ) -> (not ((occurs (FStar_Pervasives_Native.fst s) (FStar_Pervasives_Native.snd s)))))


let rec lsubst_eqns : subst Prims.list  ->  eqns  ->  eqns = (fun ( l  :  subst Prims.list ) ( uu___  :  eqns ) -> (match (uu___) with
| [] -> begin
[]
end
| ((x, y))::tl -> begin
((((lsubst_term l x)), ((lsubst_term l y))))::(lsubst_eqns l tl)
end))


let rec unify : eqns  ->  subst Prims.list  ->  subst Prims.list FStar_Pervasives_Native.option = (fun ( e  :  eqns ) ( s  :  subst Prims.list ) -> (match (e) with
| [] -> begin
FStar_Pervasives_Native.Some (s)
end
| ((V (x), t))::tl -> begin
(match (((uu___is_V t) && (Prims.op_Equality (__proj__V__item__i t) x))) with
| true -> begin
(unify tl s)
end
| uu___ -> begin
(match ((occurs x t)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___1 -> begin
(unify (lsubst_eqns ((((x), (t)))::[]) tl) ((((x), (t)))::s))
end)
end)
end
| ((t, V (x)))::tl -> begin
(unify ((((V (x)), (t)))::tl) s)
end
| ((F (t1, t2), F (t1', t2')))::tl -> begin
(unify ((((t1), (t1')))::(((t2), (t2')))::tl) s)
end))


let rec solved : eqns  ->  Prims.bool = (fun ( uu___  :  eqns ) -> (match (uu___) with
| [] -> begin
true
end
| ((x, y))::tl -> begin
((Prims.op_Equality x y) && (solved tl))
end))


let extend_subst = (fun ( s  :  'uuuuu ) ( l  :  'uuuuu Prims.list ) -> (s)::l)


let extend_lsubst = (fun ( l  :  'uuuuu Prims.list ) ( l'  :  'uuuuu Prims.list ) -> ((op_At ()) l l'))


let neutral : subst  ->  (Prims.nat * term)  ->  Prims.bool = (fun ( s  :  subst ) ( uu___  :  (Prims.nat * term) ) -> (match (uu___) with
| (x, t) -> begin
(((Prims.op_Equality (subst_term s (V (x))) (V (x))) && (Prims.op_Equality (subst_term s t) t)) && (ok ((x), (t))))
end))


let neutral_l : subst Prims.list  ->  (Prims.nat * term)  ->  Prims.bool = (fun ( l  :  subst Prims.list ) ( uu___  :  (Prims.nat * term) ) -> (match (uu___) with
| (x, t) -> begin
(((Prims.op_Equality (lsubst_term l (V (x))) (V (x))) && (Prims.op_Equality (lsubst_term l t) t)) && (ok ((x), (t))))
end))


let op_Plus_Plus = (fun ( l1  :  'uuuuu Prims.list ) ( l2  :  'uuuuu Prims.list ) -> (extend_lsubst l1 l2))


let sub : subst Prims.list  ->  eqns  ->  eqns = (fun ( l  :  subst Prims.list ) ( e  :  eqns ) -> (lsubst_eqns l e))


type not_solveable =
unit


type not_solveable_eqns =
unit


let rec unify_correct_aux : subst Prims.list  ->  eqns  ->  subst Prims.list = (fun ( l  :  subst Prims.list ) ( uu___  :  eqns ) -> (match (uu___) with
| [] -> begin
[]
end
| (hd)::tl -> begin
(match (hd) with
| (V (x), y) -> begin
(match (((uu___is_V y) && (Prims.op_Equality (__proj__V__item__i y) x))) with
| true -> begin
(unify_correct_aux l tl)
end
| uu___1 -> begin
(match ((occurs x y)) with
| true -> begin
[]
end
| uu___2 -> begin
(

let s = ((x), (y))
in (

let l' = (extend_subst s l)
in (

let tl' = (lsubst_eqns ((s)::[]) tl)
in (

let lpre = (unify_correct_aux l' tl')
in (match ((unify tl' l')) with
| FStar_Pervasives_Native.None -> begin
[]
end
| FStar_Pervasives_Native.Some (l'') -> begin
((op_At ()) lpre ((s)::[]))
end)))))
end)
end)
end
| (y, V (x)) -> begin
(unify_correct_aux l ((((V (x)), (y)))::tl))
end
| (F (t1, t2), F (s1, s2)) -> begin
(unify_correct_aux l ((((t1), (s1)))::(((t2), (s2)))::tl))
end)
end))


let unify_eqns : eqns  ->  lsubst FStar_Pervasives_Native.option = (fun ( e  :  eqns ) -> (unify e []))




