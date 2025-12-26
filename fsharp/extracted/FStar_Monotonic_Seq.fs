#light "off"
module FStar_Monotonic_Seq

type grows_aux =
unit


type grows =
unit


type rid =
unit


let snoc = (fun ( s  :  'a FStar_Seq_Base.seq ) ( x  :  'a ) -> (FStar_Seq_Base.append s (FStar_Seq_Base.create (Prims.parse_int "1") x)))


let alloc_mref_seq = (fun ( r  :  unit ) ( init  :  'a FStar_Seq_Base.seq ) -> (FStar_HyperStack_ST.ralloc () init))


type at_least =
unit


let write_at_end = (fun ( i  :  unit ) ( r  :  ('a FStar_Seq_Base.seq, grows) FStar_HyperStack_ST.m_rref ) ( x  :  'a ) -> ((FStar_HyperStack_ST.recall r);
(

let s0 = (FStar_HyperStack_ST.op_Bang r)
in (

let n = (FStar_Seq_Base.length s0)
in ((FStar_HyperStack_ST.op_Colon_Equals r (FStar_Seq_Properties.snoc s0 x));
(FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce r) ());
)));
))


type grows_p =
unit


type 'a i_seq =
('a FStar_Seq_Base.seq, unit) FStar_HyperStack_ST.m_rref


let alloc_mref_iseq = (fun ( r  :  unit ) ( init  :  'a FStar_Seq_Base.seq ) -> (FStar_HyperStack_ST.ralloc () init))


type i_at_least =
unit


type int_at_most =
unit


let i_read = (fun ( r  :  unit ) ( m  :  'a i_seq ) -> (FStar_HyperStack_ST.op_Bang m))


type i_contains =
unit


let i_write_at_end = (fun ( rgn  :  unit ) ( r  :  'a i_seq ) ( x  :  'a ) -> ((FStar_HyperStack_ST.recall r);
(

let s0 = (FStar_HyperStack_ST.op_Bang r)
in (

let n = (FStar_Seq_Base.length s0)
in ((FStar_HyperStack_ST.op_Colon_Equals r (FStar_Seq_Properties.snoc s0 x));
(FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce r) ());
)));
))


type invariant =
unit


let test0 : unit  ->  (Prims.nat FStar_Seq_Base.seq, grows) FStar_HyperStack_ST.m_rref  ->  Prims.nat  ->  unit = (fun ( r  :  unit ) ( a  :  (Prims.nat FStar_Seq_Base.seq, grows) FStar_HyperStack_ST.m_rref ) ( k  :  Prims.nat ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce a) ())))


let itest : unit  ->  Prims.nat i_seq  ->  Prims.nat  ->  unit = (fun ( r  :  unit ) ( a  :  Prims.nat i_seq ) ( k  :  Prims.nat ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce a) ())))


let un_snoc = (fun ( s  :  'a FStar_Seq_Base.seq ) -> (

let last = ((FStar_Seq_Base.length s) - (Prims.parse_int "1"))
in (((FStar_Seq_Base.slice s (Prims.parse_int "0") last)), ((FStar_Seq_Base.index s last)))))


let rec map = (fun ( f  :  'a  ->  'b ) ( s  :  'a FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let uu___1 = (un_snoc s)
in (match (uu___1) with
| (prefix, last) -> begin
(FStar_Seq_Properties.snoc (map f prefix) (f last))
end))
end))


let op_At = (fun ( s1  :  'uuuuu FStar_Seq_Base.seq ) ( s2  :  'uuuuu FStar_Seq_Base.seq ) -> (FStar_Seq_Base.append s1 s2))


type map_prefix =
unit


type map_has_at_index =
unit


let rec collect = (fun ( f  :  'a  ->  'b FStar_Seq_Base.seq ) ( s  :  'a FStar_Seq_Base.seq ) -> (match ((Prims.op_Equality (FStar_Seq_Base.length s) (Prims.parse_int "0"))) with
| true -> begin
(FStar_Seq_Base.empty ())
end
| uu___ -> begin
(

let uu___1 = (un_snoc s)
in (match (uu___1) with
| (prefix, last) -> begin
(FStar_Seq_Base.append (collect f prefix) (f last))
end))
end))


type collect_prefix =
unit


type collect_has_at_index =
unit


type 'a log_t =
('a FStar_Seq_Base.seq, unit) FStar_HyperStack_ST.m_rref


type increases =
unit


type at_most_log_len =
unit


type seqn_val =
Prims.nat


type seqn =
(seqn_val, unit) FStar_HyperStack_ST.m_rref


let new_seqn = (fun ( l  :  unit ) ( max  :  Prims.nat ) ( i  :  unit ) ( init  :  Prims.nat ) ( log  :  'a log_t ) -> ((FStar_HyperStack_ST.recall log);
(FStar_HyperStack_ST.recall_region ());
(FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce log) ());
(FStar_HyperStack_ST.ralloc () init);
))


let increment_seqn = (fun ( l  :  unit ) ( max  :  Prims.nat ) ( i  :  unit ) ( log  :  'a log_t ) ( c  :  seqn ) -> ((FStar_HyperStack_ST.recall c);
(FStar_HyperStack_ST.recall log);
(

let n = (

let uu___2 = (FStar_HyperStack_ST.op_Bang c)
in (uu___2 + (Prims.parse_int "1")))
in ((FStar_HyperStack_ST.mr_witness () () () (Prims.unsafe_coerce log) ());
(FStar_HyperStack_ST.op_Colon_Equals c n);
));
))


let testify_seqn = (fun ( i  :  unit ) ( l  :  unit ) ( log  :  'a log_t ) ( max  :  Prims.nat ) ( ctr  :  seqn ) -> (

let n = (FStar_HyperStack_ST.op_Bang ctr)
in (FStar_HyperStack_ST.testify ())))




