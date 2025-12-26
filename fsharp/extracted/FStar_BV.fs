#light "off"
module FStar_BV


let bv_uext : Prims.pos  ->  Prims.pos  ->  obj bv_t  ->  Prims.bool FStar_Seq_Base.seq = (fun ( n  :  Prims.pos ) ( i  :  Prims.pos ) ( a  :  obj bv_t ) -> (FStar_Seq_Base.append (FStar_Seq_Base.create i false) a))


let int2bv : Prims.pos  ->  FStar_UInt.uint_t  ->  obj bv_t = FStar_UInt.to_vec


let bv2int : Prims.pos  ->  obj bv_t  ->  FStar_UInt.uint_t = FStar_UInt.from_vec


let int2bv_nat : Prims.pos  ->  Prims.nat  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( num  :  Prims.nat ) -> (FStar_UInt.to_vec n (Prims.mod_f num (Prims.pow2 n))))


let list2bv : Prims.pos  ->  Prims.bool Prims.list  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( l  :  Prims.bool Prims.list ) -> (FStar_Seq_Base.seq_of_list l))


let bv2list : Prims.pos  ->  obj bv_t  ->  Prims.bool Prims.list = (fun ( n  :  Prims.pos ) ( s  :  obj bv_t ) -> (FStar_Seq_Base.seq_to_list s))


let bvand : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = FStar_BitVector.logand_vec


let bvxor : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = FStar_BitVector.logxor_vec


let bvor : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = FStar_BitVector.logor_vec


let bvnot : Prims.pos  ->  obj bv_t  ->  obj bv_t = FStar_BitVector.lognot_vec


let bvshl' : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( s  :  obj bv_t ) -> (FStar_BitVector.shift_left_vec n a (bv2int n s)))


let bvshl : Prims.pos  ->  obj bv_t  ->  Prims.nat  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( s  :  Prims.nat ) -> (bvshl' n a (int2bv_nat n s)))


let bvshr' : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( s  :  obj bv_t ) -> (FStar_BitVector.shift_right_vec n a (bv2int n s)))


let bvshr : Prims.pos  ->  obj bv_t  ->  Prims.nat  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( s  :  Prims.nat ) -> (bvshr' n a (int2bv_nat n s)))


let bv_zero : Prims.pos  ->  obj bv_t = (fun ( n  :  Prims.pos ) -> (int2bv n (Prims.parse_int "0")))


let bvult : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  Prims.bool = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  obj bv_t ) -> ((bv2int n a) < (bv2int n b)))


let bvadd : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  obj bv_t ) -> (int2bv n (FStar_UInt.add_mod n (bv2int n a) (bv2int n b))))


let bvsub : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  obj bv_t ) -> (int2bv n (FStar_UInt.sub_mod n (bv2int n a) (bv2int n b))))


let bvdiv : Prims.pos  ->  obj bv_t  ->  FStar_UInt.uint_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  FStar_UInt.uint_t ) -> (int2bv n (FStar_UInt.udiv n (bv2int n a) b)))


let bvdiv_unsafe : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  obj bv_t ) -> (match ((Prims.op_disEquality (bv2int n b) (Prims.parse_int "0"))) with
| true -> begin
(bvdiv n a (bv2int n b))
end
| uu___ -> begin
(int2bv n (Prims.parse_int "0"))
end))


let bvmod : Prims.pos  ->  obj bv_t  ->  FStar_UInt.uint_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  FStar_UInt.uint_t ) -> (int2bv n (FStar_UInt.mod1 n (bv2int n a) b)))


let bvmod_unsafe : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  obj bv_t ) -> (match ((Prims.op_disEquality (bv2int n b) (Prims.parse_int "0"))) with
| true -> begin
(bvmod n a (bv2int n b))
end
| uu___ -> begin
(int2bv n (Prims.parse_int "0"))
end))


let bvmul : Prims.pos  ->  obj bv_t  ->  FStar_UInt.uint_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  FStar_UInt.uint_t ) -> (int2bv n (FStar_UInt.mul_mod n (bv2int n a) b)))


let bvmul' : Prims.pos  ->  obj bv_t  ->  obj bv_t  ->  obj bv_t = (fun ( n  :  Prims.pos ) ( a  :  obj bv_t ) ( b  :  obj bv_t ) -> (int2bv n (FStar_UInt.mul_mod n (bv2int n a) (bv2int n b))))




