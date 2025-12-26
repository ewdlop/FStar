#light "off"
module FStar_Sequence_Permutation

type nat_at_most =
Prims.nat


type index_fun =
nat_at_most  ->  nat_at_most



type seqperm =
index_fun


let rec find = (fun ( x  :  'a ) ( s  :  'a FStar_Sequence_Base.seq ) -> (match ((Prims.op_Equality (FStar_Sequence_Util.head s) x)) with
| true -> begin
(((FStar_Sequence_Base.empty ())), ((FStar_Sequence_Util.tail s)))
end
| uu___ -> begin
(

let uu___1 = (find x (FStar_Sequence_Util.tail s))
in (match (uu___1) with
| (pfx, sfx) -> begin
(((FStar_Sequence_Util.cons (FStar_Sequence_Util.head s) pfx)), (sfx))
end))
end))


let rec permutation_from_equal_counts = (fun ( s0  :  'a FStar_Sequence_Base.seq ) ( s1  :  'a FStar_Sequence_Base.seq ) -> (match ((Prims.op_Equality (FStar_Sequence_Base.length s0) (Prims.parse_int "0"))) with
| true -> begin
(

let f = (fun ( i  :  nat_at_most ) -> i)
in f)
end
| uu___ -> begin
(

let uu___1 = (find (FStar_Sequence_Util.head s0) s1)
in (match (uu___1) with
| (pfx, sfx) -> begin
(

let s1' = (FStar_Sequence_Base.append pfx sfx)
in (

let f' = (permutation_from_equal_counts (FStar_Sequence_Util.tail s0) s1')
in (

let n = (FStar_Sequence_Base.length pfx)
in (

let f = (fun ( i  :  nat_at_most ) -> (match ((Prims.op_Equality i (Prims.parse_int "0"))) with
| true -> begin
n
end
| uu___2 -> begin
(match (((f' (i - (Prims.parse_int "1"))) < n)) with
| true -> begin
(f' (i - (Prims.parse_int "1")))
end
| uu___3 -> begin
((f' (i - (Prims.parse_int "1"))) + (Prims.parse_int "1"))
end)
end))
in f))))
end))
end))


let foldm_back = (fun ( m  :  'a FStar_Algebra_CommMonoid.cm ) ( s  :  'a FStar_Sequence_Base.seq ) -> (FStar_Sequence_Util.fold_back (FStar_Algebra_CommMonoid.__proj__CM__item__mult m) s (FStar_Algebra_CommMonoid.__proj__CM__item__unit m)))


let remove_i = (fun ( s  :  'a FStar_Sequence_Base.seq ) ( i  :  Prims.nat ) -> (

let uu___ = (FStar_Sequence_Util.split s i)
in (match (uu___) with
| (s0, s1) -> begin
(((FStar_Sequence_Util.head s1)), ((FStar_Sequence_Base.append s0 (FStar_Sequence_Util.tail s1))))
end)))


let shift_perm' = (fun ( s0  :  'a FStar_Sequence_Base.seq ) ( s1  :  'a FStar_Sequence_Base.seq ) ( uu___  :  unit ) ( p  :  seqperm ) -> (

let uu___1 = (FStar_Sequence_Util.un_build s0)
in (match (uu___1) with
| (s0', last) -> begin
(

let n = (FStar_Sequence_Base.length s0')
in (

let p' = (fun ( i  :  Prims.nat ) -> (match (((p i) < (p n))) with
| true -> begin
(p i)
end
| uu___2 -> begin
((p i) - (Prims.parse_int "1"))
end))
in (

let uu___2 = (remove_i s1 (p n))
in (match (uu___2) with
| (uu___3, s1') -> begin
p'
end))))
end)))


let shift_perm = (fun ( s0  :  'a FStar_Sequence_Base.seq ) ( s1  :  'a FStar_Sequence_Base.seq ) ( uu___  :  unit ) ( p  :  seqperm ) -> (shift_perm' s0 s1 () p))




