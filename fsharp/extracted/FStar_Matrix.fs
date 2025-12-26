#light "off"
module FStar_Matrix

type 'c matrix_generator =
FStar_IntegerIntervals.under  ->  FStar_IntegerIntervals.under  ->  'c



let get_ij : Prims.pos  ->  Prims.pos  ->  FStar_IntegerIntervals.under  ->  FStar_IntegerIntervals.under  ->  FStar_IntegerIntervals.under = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( i  :  FStar_IntegerIntervals.under ) ( j  :  FStar_IntegerIntervals.under ) -> ((i * n) + j))


let get_i : Prims.pos  ->  Prims.pos  ->  FStar_IntegerIntervals.under  ->  FStar_IntegerIntervals.under = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( ij  :  FStar_IntegerIntervals.under ) -> (ij / n))


let get_j : Prims.pos  ->  Prims.pos  ->  FStar_IntegerIntervals.under  ->  FStar_IntegerIntervals.under = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( ij  :  FStar_IntegerIntervals.under ) -> (Prims.mod_f ij n))


let transpose_ji : Prims.pos  ->  Prims.pos  ->  FStar_IntegerIntervals.under  ->  FStar_IntegerIntervals.under = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( ij  :  FStar_IntegerIntervals.under ) -> (((get_j m n ij) * m) + (get_i m n ij)))


let seq_of_matrix = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( mx  :  ('c, obj, obj) matrix ) -> mx)


let ijth = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( mx  :  ('c, obj, obj) matrix ) ( i  :  FStar_IntegerIntervals.under ) ( j  :  FStar_IntegerIntervals.under ) -> (FStar_Seq_Base.index mx (get_ij m n i j)))


let matrix_of_seq = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( s  :  'c FStar_Seq_Base.seq ) -> s)


type ('c, 'm, 'n) matrix_of =
('c, 'm, 'n) matrix


let foldm = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( cm  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( mx  :  ('c, obj, obj) matrix ) -> (FStar_Seq_Permutation.foldm_snoc eq cm mx))


let init = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( generator  :  'c matrix_generator ) -> (

let mn = (m * n)
in (

let generator_ij = (fun ( ij  :  FStar_IntegerIntervals.under ) -> (generator (get_i m n ij) (get_j m n ij)))
in (

let flat_indices = (FStar_IntegerIntervals.indices_seq mn)
in (

let result = (FStar_Seq_Properties.map_seq generator_ij flat_indices)
in result)))))


let matrix_seq = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( gen  :  'c matrix_generator ) -> (init m n gen))


let transposed_matrix_gen = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( generator  :  'c matrix_generator ) ( j  :  FStar_IntegerIntervals.under ) ( i  :  FStar_IntegerIntervals.under ) -> (generator i j))


type ('c, 'eq) matrix_eq_fun =
('c, 'eq, obj, obj) FStar_Seq_Equiv.eq_of_seq


let matrix_equiv = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) -> FStar_Algebra_CommMonoid_Equiv.EQ ((), (), (), ()))


let matrix_add_generator = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( ma  :  ('c, obj, obj) matrix ) ( mb  :  ('c, obj, obj) matrix ) ( i  :  FStar_IntegerIntervals.under ) ( j  :  FStar_IntegerIntervals.under ) -> (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__mult eq add (ijth m n ma i j) (ijth m n mb i j)))


let matrix_add = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( ma  :  ('c, obj, obj) matrix ) ( mb  :  ('c, obj, obj) matrix ) -> (init m n (matrix_add_generator eq m n add ma mb)))


let matrix_add_zero = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) -> (matrix_of_seq m n (FStar_Seq_Base.create (m * n) (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__unit eq add))))


let matrix_add_comm_monoid = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) -> FStar_Algebra_CommMonoid_Equiv.CM ((matrix_add_zero eq add m n), (matrix_add eq m n add), (), (), (), ()))


let col = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( mx  :  ('c, obj, obj) matrix ) ( j  :  FStar_IntegerIntervals.under ) -> (FStar_Seq_Base.init m (fun ( i  :  FStar_IntegerIntervals.under ) -> (ijth m n mx i j))))


let row = (fun ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( mx  :  ('c, obj, obj) matrix ) ( i  :  FStar_IntegerIntervals.under ) -> (FStar_Seq_Base.init n (fun ( j  :  FStar_IntegerIntervals.under ) -> (ijth m n mx i j))))


let seq_op_const = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( cm  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( s  :  'c FStar_Seq_Base.seq ) ( const1  :  'c ) -> (FStar_Seq_Base.init (FStar_Seq_Base.length s) (fun ( i  :  FStar_IntegerIntervals.under ) -> (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__mult eq cm (FStar_Seq_Base.index s i) const1))))


let const_op_seq = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( cm  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( const1  :  'c ) ( s  :  'c FStar_Seq_Base.seq ) -> (FStar_Seq_Base.init (FStar_Seq_Base.length s) (fun ( i  :  FStar_IntegerIntervals.under ) -> (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__mult eq cm const1 (FStar_Seq_Base.index s i)))))


let seq_of_products = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( mul  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( s  :  'c FStar_Seq_Base.seq ) ( t  :  'c FStar_Seq_Base.seq ) -> (FStar_Seq_Base.init (FStar_Seq_Base.length s) (fun ( i  :  FStar_IntegerIntervals.under ) -> (FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__mult eq mul (FStar_Seq_Base.index s i) (FStar_Seq_Base.index t i)))))


let dot = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( mul  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( s  :  'c FStar_Seq_Base.seq ) ( t  :  'c FStar_Seq_Base.seq ) -> (FStar_Seq_Permutation.foldm_snoc eq add (seq_of_products eq mul s t)))


let matrix_mul_gen = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( p  :  Prims.pos ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( mul  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( mx  :  ('c, obj, obj) matrix ) ( my  :  ('c, obj, obj) matrix ) ( i  :  FStar_IntegerIntervals.under ) ( k  :  FStar_IntegerIntervals.under ) -> (dot eq add mul (row m n mx i) (col n p my k)))


let matrix_mul = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( m  :  Prims.pos ) ( n  :  Prims.pos ) ( p  :  Prims.pos ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( mul  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( mx  :  ('c, obj, obj) matrix ) ( my  :  ('c, obj, obj) matrix ) -> (init m p (matrix_mul_gen eq m n p add mul mx my)))


type is_left_distributive =
unit


type is_right_distributive =
unit


type is_fully_distributive =
unit


type is_absorber =
unit


let matrix_mul_unit = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( add  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( mul  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( m  :  Prims.pos ) -> (init m m (fun ( i  :  FStar_IntegerIntervals.under ) ( j  :  FStar_IntegerIntervals.under ) -> (match ((Prims.op_Equality i j)) with
| true -> begin
(FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__unit eq mul)
end
| uu___ -> begin
(FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__unit eq add)
end))))




