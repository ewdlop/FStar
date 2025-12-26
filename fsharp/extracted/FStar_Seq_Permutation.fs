#light "off"
module FStar_Seq_Permutation

type index_fun =
FStar_IntegerIntervals.under  ->  FStar_IntegerIntervals.under



type seqperm =
index_fun


let rec find = (fun ( x  :  'a ) ( s  :  'a FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Properties.head s) x)) with
| true -> begin
(((FStar_Seq_Base.empty ())), ((FStar_Seq_Properties.tail s)))
end
| uu___ -> begin
(

let uu___1 = (find x (FStar_Seq_Properties.tail s))
in (match (uu___1) with
| (pfx, sfx) -> begin
(((FStar_Seq_Base.cons (FStar_Seq_Properties.head s) pfx)), (sfx))
end))
end))


let adapt_index_fun = (fun ( s  :  'a FStar_Seq_Base.seq ) ( f  :  index_fun ) ( n  :  Prims.nat ) ( i  :  FStar_IntegerIntervals.under ) -> (match ((Prims.op_Equality i (Prims.parse_int "0"))) with
| true -> begin
n
end
| uu___ -> begin
(match (((f (i - (Prims.parse_int "1"))) < n)) with
| true -> begin
(f (i - (Prims.parse_int "1")))
end
| uu___1 -> begin
((f (i - (Prims.parse_int "1"))) + (Prims.parse_int "1"))
end)
end))


let rec permutation_from_equal_counts = (fun ( s0  :  'a FStar_Seq_Base.seq ) ( s1  :  'a FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s0) (Prims.parse_int "0"))) with
| true -> begin
(

let f = (fun ( i  :  FStar_IntegerIntervals.under ) -> i)
in f)
end
| uu___ -> begin
(

let uu___1 = (find (FStar_Seq_Properties.head s0) s1)
in (match (uu___1) with
| (pfx, sfx) -> begin
(

let s1' = (FStar_Seq_Base.append pfx sfx)
in (

let f' = (permutation_from_equal_counts (FStar_Seq_Properties.tail s0) s1')
in (

let n = (FStar_Seq_Base.length pfx)
in (

let f = (adapt_index_fun s0 f' n)
in f))))
end))
end))


let foldm_snoc = (fun ( eq  :  'a FStar_Algebra_CommMonoid_Equiv.equiv ) ( m  :  ('a, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( s  :  'a FStar_Seq_Base.seq ) -> (FStar_Seq_Properties.foldr_snoc (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__mult eq m) s (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__unit eq m)))


let remove_i = (fun ( s  :  'a FStar_Seq_Base.seq ) ( i  :  Prims.nat ) -> (

let uu___ = (FStar_Seq_Properties.split s i)
in (match (uu___) with
| (s0, s1) -> begin
(((FStar_Seq_Properties.head s1)), ((FStar_Seq_Base.append s0 (FStar_Seq_Properties.tail s1))))
end)))


let shift_perm' = (fun ( s0  :  'a FStar_Seq_Base.seq ) ( s1  :  'a FStar_Seq_Base.seq ) ( uu___  :  unit ) ( p  :  seqperm ) -> (

let uu___1 = (FStar_Seq_Properties.un_snoc s0)
in (match (uu___1) with
| (s0', last) -> begin
(

let n = (FStar_Seq_Base.length s0')
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


let shift_perm = (fun ( s0  :  'a FStar_Seq_Base.seq ) ( s1  :  'a FStar_Seq_Base.seq ) ( uu___  :  unit ) ( p  :  seqperm ) -> (shift_perm' s0 s1 () p))


let init_func_from_expr = (fun ( n0  :  Prims.int ) ( nk  :  FStar_IntegerIntervals.not_less_than ) ( expr  :  FStar_IntegerIntervals.ifrom_ito  ->  'c ) ( a  :  FStar_IntegerIntervals.ifrom_ito ) ( b  :  FStar_IntegerIntervals.ifrom_ito ) ( i  :  FStar_IntegerIntervals.under ) -> (expr (n0 + i)))


let func_sum = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( cm  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( f  :  'a  ->  'c ) ( g  :  'a  ->  'c ) ( x  :  'a ) -> (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__mult eq cm (f x) (g x)))




