#light "off"
module FStar_Algebra_CommMonoid_Fold_Nested

let transpose_generator = (fun ( m0  :  Prims.int ) ( mk  :  Prims.int ) ( n0  :  Prims.int ) ( nk  :  Prims.int ) ( gen  :  FStar_IntegerIntervals.ifrom_ito  ->  FStar_IntegerIntervals.ifrom_ito  ->  'c ) ( j  :  FStar_IntegerIntervals.ifrom_ito ) ( i  :  FStar_IntegerIntervals.ifrom_ito ) -> (gen i j))


let double_fold = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( a0  :  Prims.int ) ( ak  :  FStar_IntegerIntervals.not_less_than ) ( b0  :  Prims.int ) ( bk  :  FStar_IntegerIntervals.not_less_than ) ( cm  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( g  :  FStar_IntegerIntervals.ifrom_ito  ->  FStar_IntegerIntervals.ifrom_ito  ->  'c ) -> (FStar_Algebra_CommMonoid_Fold.fold eq cm a0 ak (fun ( i  :  FStar_IntegerIntervals.ifrom_ito ) -> (FStar_Algebra_CommMonoid_Fold.fold eq cm b0 bk (g i)))))


let matrix_seq = (fun ( m  :  Prims.pos ) ( r  :  Prims.pos ) ( generator  :  'c FStar_Matrix.matrix_generator ) -> (FStar_Matrix.seq_of_matrix m r (FStar_Matrix.init m r generator)))




