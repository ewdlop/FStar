#light "off"
module FStar_Pointer_Base
type base_typ =
| TUInt
| TUInt8
| TUInt16
| TUInt32
| TUInt64
| TInt
| TInt8
| TInt16
| TInt32
| TInt64
| TChar
| TBool
| TUnit


let uu___is_TUInt : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TUInt -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TUInt8 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TUInt8 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TUInt16 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TUInt16 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TUInt32 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TUInt32 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TUInt64 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TUInt64 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TInt : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TInt -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TInt8 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TInt8 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TInt16 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TInt16 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TInt32 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TInt32 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TInt64 : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TInt64 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TChar : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TChar -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TBool : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TBool -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_TUnit : base_typ  ->  Prims.bool = (fun ( projectee  :  base_typ ) -> (match (projectee) with
| TUnit -> begin
true
end
| uu___ -> begin
false
end))


type array_length_t =
FStar_UInt32.t

type typ =
| TBase of base_typ
| TStruct of struct_typ
| TUnion of struct_typ
| TArray of array_length_t * typ
| TPointer of typ
| TNPointer of typ
| TBuffer of typ 
 and struct_typ =
{name : Prims.string; fields : (Prims.string * typ) Prims.list}


let uu___is_TBase : typ  ->  Prims.bool = (fun ( projectee  :  typ ) -> (match (projectee) with
| TBase (b) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__TBase__item__b : typ  ->  base_typ = (fun ( projectee  :  typ ) -> (match (projectee) with
| TBase (b) -> begin
b
end))


let uu___is_TStruct : typ  ->  Prims.bool = (fun ( projectee  :  typ ) -> (match (projectee) with
| TStruct (l) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__TStruct__item__l : typ  ->  struct_typ = (fun ( projectee  :  typ ) -> (match (projectee) with
| TStruct (l) -> begin
l
end))


let uu___is_TUnion : typ  ->  Prims.bool = (fun ( projectee  :  typ ) -> (match (projectee) with
| TUnion (l) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__TUnion__item__l : typ  ->  struct_typ = (fun ( projectee  :  typ ) -> (match (projectee) with
| TUnion (l) -> begin
l
end))


let uu___is_TArray : typ  ->  Prims.bool = (fun ( projectee  :  typ ) -> (match (projectee) with
| TArray (length, t) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__TArray__item__length : typ  ->  array_length_t = (fun ( projectee  :  typ ) -> (match (projectee) with
| TArray (length, t) -> begin
length
end))


let __proj__TArray__item__t : typ  ->  typ = (fun ( projectee  :  typ ) -> (match (projectee) with
| TArray (length, t) -> begin
t
end))


let uu___is_TPointer : typ  ->  Prims.bool = (fun ( projectee  :  typ ) -> (match (projectee) with
| TPointer (t) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__TPointer__item__t : typ  ->  typ = (fun ( projectee  :  typ ) -> (match (projectee) with
| TPointer (t) -> begin
t
end))


let uu___is_TNPointer : typ  ->  Prims.bool = (fun ( projectee  :  typ ) -> (match (projectee) with
| TNPointer (t) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__TNPointer__item__t : typ  ->  typ = (fun ( projectee  :  typ ) -> (match (projectee) with
| TNPointer (t) -> begin
t
end))


let uu___is_TBuffer : typ  ->  Prims.bool = (fun ( projectee  :  typ ) -> (match (projectee) with
| TBuffer (t) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__TBuffer__item__t : typ  ->  typ = (fun ( projectee  :  typ ) -> (match (projectee) with
| TBuffer (t) -> begin
t
end))


let __proj__Mkstruct_typ__item__name : struct_typ  ->  Prims.string = (fun ( projectee  :  struct_typ ) -> (match (projectee) with
| {name = name; fields = fields} -> begin
name
end))


let __proj__Mkstruct_typ__item__fields : struct_typ  ->  (Prims.string * typ) Prims.list = (fun ( projectee  :  struct_typ ) -> (match (projectee) with
| {name = name; fields = fields} -> begin
fields
end))


type struct_typ' =
(Prims.string * typ) Prims.list


type union_typ =
struct_typ


type struct_field' =
Prims.string


type struct_field =
struct_field'


type union_field =
struct_field


let typ_of_struct_field' : struct_typ'  ->  struct_field'  ->  typ = (fun ( l  :  struct_typ' ) ( f  :  struct_field' ) -> (

let y = (FStar_Pervasives_Native.__proj__Some__item__v (FStar_List_Tot_Base.assoc f l))
in y))


let typ_of_struct_field : struct_typ  ->  struct_field  ->  typ = (fun ( l  :  struct_typ ) ( f  :  struct_field ) -> (typ_of_struct_field' l.fields f))


let typ_of_union_field : union_typ  ->  union_field  ->  typ = (fun ( l  :  union_typ ) ( f  :  union_field ) -> (typ_of_struct_field l f))

type ('dummyV0, 'dummyV1) step =
| StepField of struct_typ * struct_field
| StepUField of union_typ * struct_field
| StepCell of FStar_UInt32.t * typ * FStar_UInt32.t


let uu___is_StepField : typ  ->  typ  ->  (obj, obj) step  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepField (l, fd) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__StepField__item__l : typ  ->  typ  ->  (obj, obj) step  ->  struct_typ = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepField (l, fd) -> begin
l
end))


let __proj__StepField__item__fd : typ  ->  typ  ->  (obj, obj) step  ->  struct_field = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepField (l, fd) -> begin
fd
end))


let uu___is_StepUField : typ  ->  typ  ->  (obj, obj) step  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepUField (l, fd) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__StepUField__item__l : typ  ->  typ  ->  (obj, obj) step  ->  union_typ = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepUField (l, fd) -> begin
l
end))


let __proj__StepUField__item__fd : typ  ->  typ  ->  (obj, obj) step  ->  struct_field = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepUField (l, fd) -> begin
fd
end))


let uu___is_StepCell : typ  ->  typ  ->  (obj, obj) step  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepCell (length, value, index) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__StepCell__item__length : typ  ->  typ  ->  (obj, obj) step  ->  FStar_UInt32.t = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepCell (length, value, index) -> begin
length
end))


let __proj__StepCell__item__value : typ  ->  typ  ->  (obj, obj) step  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepCell (length, value, index) -> begin
value
end))


let __proj__StepCell__item__index : typ  ->  typ  ->  (obj, obj) step  ->  FStar_UInt32.t = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) step ) -> (match (projectee) with
| StepCell (length, value, index) -> begin
index
end))

type ('from, 'dummyV0) path =
| PathBase
| PathStep of typ * typ * ('from, obj) path * (obj, obj) step


let uu___is_PathBase : typ  ->  typ  ->  (obj, obj) path  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) path ) -> (match (projectee) with
| PathBase -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_PathStep : typ  ->  typ  ->  (obj, obj) path  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) path ) -> (match (projectee) with
| PathStep (through, to2, p, s) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__PathStep__item__through : typ  ->  typ  ->  (obj, obj) path  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) path ) -> (match (projectee) with
| PathStep (through, to2, p, s) -> begin
through
end))


let __proj__PathStep__item__to : typ  ->  typ  ->  (obj, obj) path  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) path ) -> (match (projectee) with
| PathStep (through, to2, p, s) -> begin
to2
end))


let __proj__PathStep__item__p : typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) path ) -> (match (projectee) with
| PathStep (through, to2, p, s) -> begin
p
end))


let __proj__PathStep__item__s : typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) step = (fun ( from  :  typ ) ( to1  :  typ ) ( projectee  :  (obj, obj) path ) -> (match (projectee) with
| PathStep (through, to2, p, s) -> begin
s
end))

type 'to1 _npointer =
| Pointer of typ * FStar_Monotonic_HyperStack.aref * (obj, 'to1) path
| NullPtr


let uu___is_Pointer : typ  ->  obj _npointer  ->  Prims.bool = (fun ( to1  :  typ ) ( projectee  :  obj _npointer ) -> (match (projectee) with
| Pointer (from, contents, p) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Pointer__item__from : typ  ->  obj _npointer  ->  typ = (fun ( to1  :  typ ) ( projectee  :  obj _npointer ) -> (match (projectee) with
| Pointer (from, contents, p) -> begin
from
end))


let __proj__Pointer__item__contents : typ  ->  obj _npointer  ->  FStar_Monotonic_HyperStack.aref = (fun ( to1  :  typ ) ( projectee  :  obj _npointer ) -> (match (projectee) with
| Pointer (from, contents, p) -> begin
contents
end))


let __proj__Pointer__item__p : typ  ->  obj _npointer  ->  (obj, obj) path = (fun ( to1  :  typ ) ( projectee  :  obj _npointer ) -> (match (projectee) with
| Pointer (from, contents, p) -> begin
p
end))


let uu___is_NullPtr : typ  ->  obj _npointer  ->  Prims.bool = (fun ( to1  :  typ ) ( projectee  :  obj _npointer ) -> (match (projectee) with
| NullPtr -> begin
true
end
| uu___ -> begin
false
end))


type 't npointer =
't _npointer


let nullptr : typ  ->  obj npointer = (fun ( t  :  typ ) -> NullPtr)


type 't pointer =
't npointer

type 't buffer_root =
| BufferRootSingleton of 't pointer
| BufferRootArray of array_length_t * obj pointer


let uu___is_BufferRootSingleton : typ  ->  obj buffer_root  ->  Prims.bool = (fun ( t  :  typ ) ( projectee  :  obj buffer_root ) -> (match (projectee) with
| BufferRootSingleton (p) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__BufferRootSingleton__item__p : typ  ->  obj buffer_root  ->  obj pointer = (fun ( t  :  typ ) ( projectee  :  obj buffer_root ) -> (match (projectee) with
| BufferRootSingleton (p) -> begin
p
end))


let uu___is_BufferRootArray : typ  ->  obj buffer_root  ->  Prims.bool = (fun ( t  :  typ ) ( projectee  :  obj buffer_root ) -> (match (projectee) with
| BufferRootArray (max_length, p) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__BufferRootArray__item__max_length : typ  ->  obj buffer_root  ->  array_length_t = (fun ( t  :  typ ) ( projectee  :  obj buffer_root ) -> (match (projectee) with
| BufferRootArray (max_length, p) -> begin
max_length
end))


let __proj__BufferRootArray__item__p : typ  ->  obj buffer_root  ->  obj pointer = (fun ( t  :  typ ) ( projectee  :  obj buffer_root ) -> (match (projectee) with
| BufferRootArray (max_length, p) -> begin
p
end))


let buffer_root_length : typ  ->  obj buffer_root  ->  FStar_UInt32.t = (fun ( t  :  typ ) ( b  :  obj buffer_root ) -> (match (b) with
| BufferRootSingleton (uu___) -> begin
(FStar_UInt32.uint_to_t ((Prims.parse_int "1")))
end
| BufferRootArray (len, uu___) -> begin
len
end))

type 't _buffer =
| Buffer of 't buffer_root * FStar_UInt32.t * FStar_UInt32.t


let uu___is_Buffer : typ  ->  obj _buffer  ->  Prims.bool = (fun ( t  :  typ ) ( projectee  :  obj _buffer ) -> true)


let __proj__Buffer__item__broot : typ  ->  obj _buffer  ->  obj buffer_root = (fun ( t  :  typ ) ( projectee  :  obj _buffer ) -> (match (projectee) with
| Buffer (broot, bidx, blength) -> begin
broot
end))


let __proj__Buffer__item__bidx : typ  ->  obj _buffer  ->  FStar_UInt32.t = (fun ( t  :  typ ) ( projectee  :  obj _buffer ) -> (match (projectee) with
| Buffer (broot, bidx, blength) -> begin
bidx
end))


let __proj__Buffer__item__blength : typ  ->  obj _buffer  ->  FStar_UInt32.t = (fun ( t  :  typ ) ( projectee  :  obj _buffer ) -> (match (projectee) with
| Buffer (broot, bidx, blength) -> begin
blength
end))


type 't buffer =
't _buffer


type type_of_base_typ =
obj


type 't array =
't FStar_Seq_Base.seq


type 'typeuofutyp type_of_struct_field'' =
'typeuofutyp


type 'typeuofutyp type_of_struct_field' =
'typeuofutyp type_of_struct_field''


type ('key, 'value) gtdata =
('key, 'value) Prims.dtuple2


let _gtdata_get_key = (fun ( u  :  ('key, 'value) gtdata ) -> (FStar_Pervasives.dfst u))


let gtdata_get_value = (fun ( u  :  ('key, 'value) gtdata ) ( k  :  'key ) -> (

let uu___ = u
in (match (uu___) with
| Prims.Mkdtuple2 (uu___1, v) -> begin
v
end)))


let gtdata_create = (fun ( k  :  'key ) ( v  :  'value ) -> Prims.Mkdtuple2 (k, v))


type type_of_typ' =
obj


type struct1 =
obj


type union =
obj


type type_of_typ =
obj


type type_of_struct_field =
obj


let _union_get_key : union_typ  ->  obj  ->  struct_field = (fun ( l  :  union_typ ) ( v  :  obj ) -> (_gtdata_get_key (Prims.unsafe_coerce v)))


let struct_sel : struct_typ  ->  obj  ->  struct_field  ->  obj = (fun ( l  :  struct_typ ) ( s  :  obj ) ( f  :  struct_field ) -> (FStar_DependentMap.sel (Prims.unsafe_coerce s) f))


let dfst_struct_field : struct_typ  ->  (struct_field, obj) Prims.dtuple2  ->  Prims.string = (fun ( s  :  struct_typ ) ( p  :  (struct_field, obj) Prims.dtuple2 ) -> (

let uu___ = p
in (match (uu___) with
| Prims.Mkdtuple2 (f, uu___1) -> begin
f
end)))


type struct_literal =
(struct_field, obj) Prims.dtuple2 Prims.list


let struct_literal_wf : struct_typ  ->  struct_literal  ->  Prims.bool = (fun ( s  :  struct_typ ) ( l  :  struct_literal ) -> (Prims.op_Equality (FStar_List_Tot_Base.sortWith FStar_String.compare (FStar_List_Tot_Base.map FStar_Pervasives_Native.fst s.fields)) (FStar_List_Tot_Base.sortWith FStar_String.compare (FStar_List_Tot_Base.map (dfst_struct_field s) l))))


let fun_of_list : struct_typ  ->  struct_literal  ->  struct_field  ->  obj = (fun ( s  :  struct_typ ) ( l  :  struct_literal ) ( f  :  struct_field ) -> (

let f' = f
in (

let phi = (fun ( p  :  (struct_field, obj) Prims.dtuple2 ) -> (Prims.op_Equality (dfst_struct_field s p) f'))
in (match ((FStar_List_Tot_Base.find phi l)) with
| FStar_Pervasives_Native.Some (p) -> begin
(

let uu___ = p
in (match (uu___) with
| Prims.Mkdtuple2 (uu___1, v) -> begin
v
end))
end
| uu___ -> begin
(FStar_Pervasives.false_elim ())
end))))


let struct_upd : struct_typ  ->  obj  ->  struct_field  ->  obj  ->  obj = (fun ( uu___3  :  struct_typ ) ( uu___2  :  obj ) ( uu___1  :  struct_field ) ( uu___  :  obj ) -> ((fun ( l  :  struct_typ ) ( s  :  obj ) ( f  :  struct_field ) ( v  :  obj ) -> (Prims.unsafe_coerce (FStar_DependentMap.upd (Prims.unsafe_coerce s) f v))) uu___3 uu___2 uu___1 uu___))


let struct_create_fun : struct_typ  ->  (struct_field  ->  obj)  ->  obj = (fun ( uu___1  :  struct_typ ) ( uu___  :  struct_field  ->  obj ) -> ((fun ( l  :  struct_typ ) ( f  :  (struct_field  ->  obj) ) -> (Prims.unsafe_coerce (FStar_DependentMap.create f))) uu___1 uu___))


let struct_create : struct_typ  ->  struct_literal  ->  obj = (fun ( s  :  struct_typ ) ( l  :  struct_literal ) -> (struct_create_fun s (fun_of_list s l)))


let union_get_value : union_typ  ->  obj  ->  struct_field  ->  obj = (fun ( l  :  union_typ ) ( v  :  obj ) ( fd  :  struct_field ) -> (gtdata_get_value (Prims.unsafe_coerce v) fd))


let union_create : union_typ  ->  struct_field  ->  obj  ->  obj = (fun ( uu___2  :  union_typ ) ( uu___1  :  struct_field ) ( uu___  :  obj ) -> ((fun ( l  :  union_typ ) ( fd  :  struct_field ) ( v  :  obj ) -> (Prims.unsafe_coerce (gtdata_create fd v))) uu___2 uu___1 uu___))


let rec dummy_val : typ  ->  obj = (fun ( t  :  typ ) -> (match (t) with
| TBase (b) -> begin
(box (match (b) with
| TUInt -> begin
(box (Prims.parse_int "0"))
end
| TUInt8 -> begin
(box (FStar_UInt8.uint_to_t (Prims.parse_int "0")))
end
| TUInt16 -> begin
(box (FStar_UInt16.uint_to_t (Prims.parse_int "0")))
end
| TUInt32 -> begin
(box (FStar_UInt32.uint_to_t (Prims.parse_int "0")))
end
| TUInt64 -> begin
(box (FStar_UInt64.uint_to_t (Prims.parse_int "0")))
end
| TInt -> begin
(box (Prims.parse_int "0"))
end
| TInt8 -> begin
(box (FStar_Int8.int_to_t (Prims.parse_int "0")))
end
| TInt16 -> begin
(box (FStar_Int16.int_to_t (Prims.parse_int "0")))
end
| TInt32 -> begin
(box (FStar_Int32.int_to_t (Prims.parse_int "0")))
end
| TInt64 -> begin
(box (FStar_Int64.int_to_t (Prims.parse_int "0")))
end
| TChar -> begin
(box 'c')
end
| TBool -> begin
(box false)
end
| TUnit -> begin
(box ())
end))
end
| TStruct (l) -> begin
(box (struct_create_fun l (fun ( f  :  struct_field ) -> (dummy_val (typ_of_struct_field l f)))))
end
| TUnion (l) -> begin
(box (

let dummy_field = (FStar_List_Tot_Base.hd (FStar_List_Tot_Base.map FStar_Pervasives_Native.fst l.fields))
in (union_create l dummy_field (dummy_val (typ_of_struct_field l dummy_field)))))
end
| TArray (length, t1) -> begin
(box (FStar_Seq_Base.create (FStar_UInt32.v length) (dummy_val t1)))
end
| TPointer (t1) -> begin
(box (Pointer (t1, FStar_Monotonic_HyperStack.dummy_aref, PathBase)))
end
| TNPointer (t1) -> begin
(box NullPtr)
end
| TBuffer (t1) -> begin
(box (Buffer (BufferRootSingleton (Pointer (t1, FStar_Monotonic_HyperStack.dummy_aref, PathBase)), (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))))))
end))


type otype_of_typ =
obj


type otype_of_struct_field =
obj


type ostruct =
(struct_field, obj) FStar_DependentMap.t FStar_Pervasives_Native.option


let ostruct_sel : struct_typ  ->  ostruct  ->  struct_field  ->  obj = (fun ( l  :  struct_typ ) ( s  :  ostruct ) ( f  :  struct_field ) -> (FStar_DependentMap.sel (FStar_Pervasives_Native.__proj__Some__item__v s) f))


let ostruct_upd : struct_typ  ->  ostruct  ->  struct_field  ->  obj  ->  ostruct = (fun ( l  :  struct_typ ) ( s  :  ostruct ) ( f  :  struct_field ) ( v  :  obj ) -> FStar_Pervasives_Native.Some ((FStar_DependentMap.upd (FStar_Pervasives_Native.__proj__Some__item__v s) f v)))


let ostruct_create : struct_typ  ->  (struct_field  ->  obj)  ->  ostruct = (fun ( l  :  struct_typ ) ( f  :  struct_field  ->  obj ) -> FStar_Pervasives_Native.Some ((FStar_DependentMap.create f)))


type ounion =
(struct_field, obj) gtdata FStar_Pervasives_Native.option


let ounion_get_key : union_typ  ->  ounion  ->  struct_field = (fun ( l  :  union_typ ) ( v  :  ounion ) -> (_gtdata_get_key (FStar_Pervasives_Native.__proj__Some__item__v v)))


let ounion_get_value : union_typ  ->  ounion  ->  struct_field  ->  obj = (fun ( l  :  union_typ ) ( v  :  ounion ) ( fd  :  struct_field ) -> (gtdata_get_value (FStar_Pervasives_Native.__proj__Some__item__v v) fd))


let ounion_create : union_typ  ->  struct_field  ->  obj  ->  ounion = (fun ( l  :  union_typ ) ( fd  :  struct_field ) ( v  :  obj ) -> FStar_Pervasives_Native.Some ((gtdata_create fd v)))


let struct_field_is_readable : struct_typ  ->  (typ  ->  obj  ->  Prims.bool)  ->  ostruct  ->  Prims.string  ->  Prims.bool = (fun ( l  :  struct_typ ) ( ovalue_is_readable  :  typ  ->  obj  ->  Prims.bool ) ( v  :  ostruct ) ( s  :  Prims.string ) -> (match ((FStar_List_Tot_Base.mem s (FStar_List_Tot_Base.map FStar_Pervasives_Native.fst l.fields))) with
| true -> begin
(ovalue_is_readable (typ_of_struct_field l s) (ostruct_sel l v s))
end
| uu___ -> begin
true
end))


let rec ovalue_is_readable : typ  ->  obj  ->  Prims.bool = (fun ( t  :  typ ) ( v  :  obj ) -> (match (t) with
| TStruct (l) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in ((FStar_Pervasives_Native.uu___is_Some v1) && (

let keys = (FStar_List_Tot_Base.map FStar_Pervasives_Native.fst l.fields)
in (

let pred = (fun ( t'  :  typ ) ( v2  :  obj ) -> (ovalue_is_readable t' v2))
in (FStar_List_Tot_Base.for_all (struct_field_is_readable l pred v1) keys)))))
end
| TUnion (l) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in ((FStar_Pervasives_Native.uu___is_Some v1) && (

let k = (ounion_get_key l v1)
in (ovalue_is_readable (typ_of_struct_field l k) (ounion_get_value l v1 k)))))
end
| TArray (len, t1) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in ((FStar_Pervasives_Native.uu___is_Some v1) && (FStar_Seq_Properties.for_all (ovalue_is_readable t1) (FStar_Pervasives_Native.__proj__Some__item__v v1))))
end
| TBase (t1) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (FStar_Pervasives_Native.uu___is_Some v1))
end
| TPointer (t1) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (FStar_Pervasives_Native.uu___is_Some v1))
end
| TNPointer (t1) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (FStar_Pervasives_Native.uu___is_Some v1))
end
| TBuffer (t1) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (FStar_Pervasives_Native.uu___is_Some v1))
end))


let ostruct_field_of_struct_field : struct_typ  ->  (typ  ->  obj  ->  obj)  ->  obj  ->  struct_field  ->  obj = (fun ( l  :  struct_typ ) ( ovalue_of_value  :  typ  ->  obj  ->  obj ) ( v  :  obj ) ( f  :  struct_field ) -> (ovalue_of_value (typ_of_struct_field l f) (struct_sel l v f)))


let rec ovalue_of_value : typ  ->  obj  ->  obj = (fun ( t  :  typ ) ( v  :  obj ) -> (match (t) with
| TStruct (l) -> begin
(box (

let oval = (fun ( t'  :  typ ) ( v'  :  obj ) -> (ovalue_of_value t' v'))
in (ostruct_create l (ostruct_field_of_struct_field l oval v))))
end
| TArray (len, t1) -> begin
(box (

let v1 = (Prims.unsafe_coerce v)
in (

let f = (fun ( i  :  Prims.nat ) -> (ovalue_of_value t1 (FStar_Seq_Base.index v1 i)))
in (

let v' = (FStar_Seq_Base.init (FStar_UInt32.v len) f)
in FStar_Pervasives_Native.Some (v')))))
end
| TUnion (l) -> begin
(box (

let v1 = v
in (

let k = (_union_get_key l v1)
in (ounion_create l k (ovalue_of_value (typ_of_struct_field l k) (union_get_value l v1 k))))))
end
| uu___ -> begin
(box (FStar_Pervasives_Native.Some (v)))
end))


let rec value_of_ovalue : typ  ->  obj  ->  obj = (fun ( t  :  typ ) ( v  :  obj ) -> (match (t) with
| TStruct (l) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (match ((FStar_Pervasives_Native.uu___is_Some v1)) with
| true -> begin
(

let phi = (fun ( f  :  struct_field ) -> (value_of_ovalue (typ_of_struct_field l f) (ostruct_sel l v1 f)))
in (struct_create_fun l phi))
end
| uu___ -> begin
(dummy_val t)
end))
end
| TArray (len, t') -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (match (v1) with
| FStar_Pervasives_Native.None -> begin
(box (dummy_val t))
end
| FStar_Pervasives_Native.Some (v2) -> begin
(box (

let phi = (fun ( i  :  Prims.nat ) -> (value_of_ovalue t' (FStar_Seq_Base.index v2 i)))
in (FStar_Seq_Base.init (FStar_UInt32.v len) phi)))
end))
end
| TUnion (l) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (match (v1) with
| FStar_Pervasives_Native.None -> begin
(dummy_val t)
end
| uu___ -> begin
(

let k = (ounion_get_key l v1)
in (union_create l k (value_of_ovalue (typ_of_struct_field l k) (ounion_get_value l v1 k))))
end))
end
| TBase (b) -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (match (v1) with
| FStar_Pervasives_Native.None -> begin
(dummy_val t)
end
| FStar_Pervasives_Native.Some (v2) -> begin
v2
end))
end
| TPointer (t') -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (match (v1) with
| FStar_Pervasives_Native.None -> begin
(box (dummy_val t))
end
| FStar_Pervasives_Native.Some (v2) -> begin
(box v2)
end))
end
| TNPointer (t') -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (match (v1) with
| FStar_Pervasives_Native.None -> begin
(box (dummy_val t))
end
| FStar_Pervasives_Native.Some (v2) -> begin
(box v2)
end))
end
| TBuffer (t') -> begin
(

let v1 = (Prims.unsafe_coerce v)
in (match (v1) with
| FStar_Pervasives_Native.None -> begin
(box (dummy_val t))
end
| FStar_Pervasives_Native.Some (v2) -> begin
(box v2)
end))
end))


let none_ovalue : typ  ->  obj = (fun ( t  :  typ ) -> (match (t) with
| TStruct (l) -> begin
(box FStar_Pervasives_Native.None)
end
| TArray (len, t') -> begin
(box FStar_Pervasives_Native.None)
end
| TUnion (l) -> begin
(box FStar_Pervasives_Native.None)
end
| TBase (b) -> begin
(box FStar_Pervasives_Native.None)
end
| TPointer (t') -> begin
(box FStar_Pervasives_Native.None)
end
| TNPointer (t') -> begin
(box FStar_Pervasives_Native.None)
end
| TBuffer (t') -> begin
(box FStar_Pervasives_Native.None)
end))


let step_sel : typ  ->  typ  ->  obj  ->  (obj, obj) step  ->  obj = (fun ( from  :  typ ) ( to1  :  typ ) ( m'  :  obj ) ( s  :  (obj, obj) step ) -> (match (s) with
| StepField (l, fd) -> begin
(

let m'1 = (Prims.unsafe_coerce m')
in (match (m'1) with
| FStar_Pervasives_Native.None -> begin
(none_ovalue to1)
end
| uu___ -> begin
(ostruct_sel l m'1 fd)
end))
end
| StepUField (l, fd) -> begin
(

let m'1 = (Prims.unsafe_coerce m')
in (match (m'1) with
| FStar_Pervasives_Native.None -> begin
(none_ovalue to1)
end
| uu___ -> begin
(match ((Prims.op_Equality fd (ounion_get_key l m'1))) with
| true -> begin
(ounion_get_value l m'1 fd)
end
| uu___1 -> begin
(none_ovalue to1)
end)
end))
end
| StepCell (length, value, i) -> begin
(

let m'1 = (Prims.unsafe_coerce m')
in (match (m'1) with
| FStar_Pervasives_Native.None -> begin
(none_ovalue to1)
end
| FStar_Pervasives_Native.Some (m'2) -> begin
(FStar_Seq_Base.index m'2 (FStar_UInt32.v i))
end))
end))


let rec path_sel : typ  ->  typ  ->  obj  ->  (obj, obj) path  ->  obj = (fun ( from  :  typ ) ( to1  :  typ ) ( m  :  obj ) ( p  :  (obj, obj) path ) -> (match (p) with
| PathBase -> begin
m
end
| PathStep (through', to', p', s) -> begin
(

let m' = (path_sel from through' m p')
in (step_sel through' to' m' s))
end))


let step_upd : typ  ->  typ  ->  obj  ->  (obj, obj) step  ->  obj  ->  obj = (fun ( from  :  typ ) ( to1  :  typ ) ( m  :  obj ) ( s  :  (obj, obj) step ) ( v  :  obj ) -> (match (s) with
| StepField (l, fd) -> begin
(box (

let m1 = (Prims.unsafe_coerce m)
in (match (m1) with
| FStar_Pervasives_Native.None -> begin
(

let phi = (fun ( fd'  :  struct_field ) -> (match ((Prims.op_Equality fd' fd)) with
| true -> begin
v
end
| uu___ -> begin
(none_ovalue (typ_of_struct_field l fd'))
end))
in (ostruct_create l phi))
end
| FStar_Pervasives_Native.Some (uu___) -> begin
(ostruct_upd l m1 fd v)
end)))
end
| StepCell (len, uu___, i) -> begin
(box (

let m1 = (Prims.unsafe_coerce m)
in (match (m1) with
| FStar_Pervasives_Native.None -> begin
(

let phi = (fun ( j  :  Prims.nat ) -> (match ((Prims.op_Equality j (FStar_UInt32.v i))) with
| true -> begin
v
end
| uu___1 -> begin
(none_ovalue to1)
end))
in (

let m' = FStar_Pervasives_Native.Some ((FStar_Seq_Base.init (FStar_UInt32.v len) phi))
in m'))
end
| FStar_Pervasives_Native.Some (m2) -> begin
(

let m' = FStar_Pervasives_Native.Some ((FStar_Seq_Base.upd m2 (FStar_UInt32.v i) v))
in m')
end)))
end
| StepUField (l, fd) -> begin
(box (ounion_create l fd v))
end))


let rec path_upd : typ  ->  typ  ->  obj  ->  (obj, obj) path  ->  obj  ->  obj = (fun ( from  :  typ ) ( to1  :  typ ) ( m  :  obj ) ( p  :  (obj, obj) path ) ( v  :  obj ) -> (match (p) with
| PathBase -> begin
v
end
| PathStep (through', to', p', st) -> begin
(

let s = (path_sel from through' m p')
in (path_upd from through' m p' (step_upd through' to' s st v)))
end))


let rec path_concat : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj) path = (fun ( from  :  typ ) ( through  :  typ ) ( to1  :  typ ) ( p  :  (obj, obj) path ) ( q  :  (obj, obj) path ) -> (match (q) with
| PathBase -> begin
p
end
| PathStep (through', to', q', st) -> begin
PathStep (through', to', (path_concat from through through' p q'), st)
end))


let rec path_length : typ  ->  typ  ->  (obj, obj) path  ->  Prims.nat = (fun ( from  :  typ ) ( to1  :  typ ) ( p  :  (obj, obj) path ) -> (match (p) with
| PathBase -> begin
(Prims.parse_int "0")
end
| PathStep (uu___, uu___1, p', uu___2) -> begin
((Prims.parse_int "1") + (path_length from uu___ p'))
end))


let step_eq : typ  ->  typ  ->  typ  ->  (obj, obj) step  ->  (obj, obj) step  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( s1  :  (obj, obj) step ) ( s2  :  (obj, obj) step ) -> (match (s1) with
| StepField (l1, fd1) -> begin
(

let uu___ = s2
in (match (uu___) with
| StepField (uu___1, fd2) -> begin
(Prims.op_Equality fd1 fd2)
end))
end
| StepCell (uu___, uu___1, i1) -> begin
(

let uu___2 = s2
in (match (uu___2) with
| StepCell (uu___3, uu___4, i2) -> begin
(Prims.op_Equality i1 i2)
end))
end
| StepUField (l1, fd1) -> begin
(

let uu___ = s2
in (match (uu___) with
| StepUField (uu___1, fd2) -> begin
(Prims.op_Equality fd1 fd2)
end))
end))

type ('from, 'dummyV0, 'dummyV1, 'dummyV2, 'dummyV3) path_disjoint_t =
| PathDisjointStep of typ * typ * typ * ('from, obj) path * (obj, obj) step * (obj, obj) step
| PathDisjointIncludes of typ * typ * ('from, obj) path * ('from, obj) path * typ * typ * ('from, obj) path * ('from, obj) path * ('from, obj, obj, obj, obj) path_disjoint_t


let uu___is_PathDisjointStep : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointStep (through, to11, to21, p, s1, s2) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__PathDisjointStep__item__through : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointStep (through, to11, to21, p, s1, s2) -> begin
through
end))


let __proj__PathDisjointStep__item__to1 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointStep (through, to11, to21, p, s1, s2) -> begin
to11
end))


let __proj__PathDisjointStep__item__to2 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointStep (through, to11, to21, p, s1, s2) -> begin
to21
end))


let __proj__PathDisjointStep__item__p : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointStep (through, to11, to21, p, s1, s2) -> begin
p
end))


let __proj__PathDisjointStep__item__s1 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj) step = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointStep (through, to11, to21, p, s1, s2) -> begin
s1
end))


let __proj__PathDisjointStep__item__s2 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj) step = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointStep (through, to11, to21, p, s1, s2) -> begin
s2
end))


let uu___is_PathDisjointIncludes : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__PathDisjointIncludes__item__to1 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
to11
end))


let __proj__PathDisjointIncludes__item__to2 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
to21
end))


let __proj__PathDisjointIncludes__item__p1 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
p11
end))


let __proj__PathDisjointIncludes__item__p2 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
p21
end))


let __proj__PathDisjointIncludes__item__to1' : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
to1'
end))


let __proj__PathDisjointIncludes__item__to2' : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  typ = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
to2'
end))


let __proj__PathDisjointIncludes__item__p1' : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
p1'
end))


let __proj__PathDisjointIncludes__item__p2' : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
p2'
end))


let __proj__PathDisjointIncludes__item___8 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_t  ->  (obj, obj, obj, obj, obj) path_disjoint_t = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_t ) -> (match (projectee) with
| PathDisjointIncludes (to11, to21, p11, p21, to1', to2', p1', p2', _8) -> begin
_8
end))


type path_disjoint =
unit


let rec path_equal : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  Prims.bool = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) -> (match (p1) with
| PathBase -> begin
(uu___is_PathBase from value2 p2)
end
| PathStep (uu___, uu___1, p1', s1) -> begin
((uu___is_PathStep from value2 p2) && (

let uu___2 = p2
in (match (uu___2) with
| PathStep (uu___3, uu___4, p2', s2) -> begin
((path_equal from uu___ uu___3 p1' p2') && (step_eq uu___ uu___1 uu___4 s1 s2))
end)))
end))

type ('from, 'value1, 'value2, 'p1, 'p2) path_disjoint_decomp_t =
| PathDisjointDecomp of typ * ('from, obj) path * typ * (obj, obj) step * (obj, 'value1) path * typ * (obj, obj) step * (obj, 'value2) path * unit


let uu___is_PathDisjointDecomp : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  Prims.bool = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> true)


let __proj__PathDisjointDecomp__item__d_through : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  typ = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_through
end))


let __proj__PathDisjointDecomp__item__d_p : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_p
end))


let __proj__PathDisjointDecomp__item__d_v1 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  typ = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_v1
end))


let __proj__PathDisjointDecomp__item__d_s1 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  (obj, obj) step = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_s1
end))


let __proj__PathDisjointDecomp__item__d_p1' : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_p1'
end))


let __proj__PathDisjointDecomp__item__d_v2 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  typ = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_v2
end))


let __proj__PathDisjointDecomp__item__d_s2 : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  (obj, obj) step = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_s2
end))


let __proj__PathDisjointDecomp__item__d_p2' : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  (obj, obj, obj, obj, obj) path_disjoint_decomp_t  ->  (obj, obj) path = (fun ( from  :  typ ) ( value1  :  typ ) ( value2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) ( projectee  :  (obj, obj, obj, obj, obj) path_disjoint_decomp_t ) -> (match (projectee) with
| PathDisjointDecomp (d_through, d_p, d_v1, d_s1, d_p1', d_v2, d_s2, d_p2', _8) -> begin
d_p2'
end))


let rec path_destruct_l : typ  ->  typ  ->  (obj, obj) path  ->  (typ, ((obj, obj) step, (obj, obj) path) Prims.dtuple2) Prims.dtuple2 FStar_Pervasives_Native.option = (fun ( t0  :  typ ) ( t2  :  typ ) ( p  :  (obj, obj) path ) -> (match (p) with
| PathBase -> begin
FStar_Pervasives_Native.None
end
| PathStep (uu___, uu___1, p', s) -> begin
(match ((path_destruct_l t0 uu___ p')) with
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.Some (Prims.Mkdtuple2 (t2, Prims.Mkdtuple2 (s, PathBase)))
end
| FStar_Pervasives_Native.Some (Prims.Mkdtuple2 (t_, Prims.Mkdtuple2 (s_, p_))) -> begin
FStar_Pervasives_Native.Some (Prims.Mkdtuple2 (t_, Prims.Mkdtuple2 (s_, PathStep (uu___, uu___1, p_, s))))
end)
end))


let rec path_equal' : typ  ->  typ  ->  typ  ->  (obj, obj) path  ->  (obj, obj) path  ->  Prims.bool = (fun ( from  :  typ ) ( to1  :  typ ) ( to2  :  typ ) ( p1  :  (obj, obj) path ) ( p2  :  (obj, obj) path ) -> (match ((path_destruct_l from to1 p1)) with
| FStar_Pervasives_Native.None -> begin
(uu___is_PathBase from to2 p2)
end
| FStar_Pervasives_Native.Some (Prims.Mkdtuple2 (t1, Prims.Mkdtuple2 (s1, p1'))) -> begin
(match ((path_destruct_l from to2 p2)) with
| FStar_Pervasives_Native.None -> begin
false
end
| FStar_Pervasives_Native.Some (Prims.Mkdtuple2 (t2, Prims.Mkdtuple2 (s2, p2'))) -> begin
((step_eq from t1 t2 s1 s2) && (path_equal' t1 to1 to2 p1' p2'))
end)
end))


let _field : struct_typ  ->  obj pointer  ->  struct_field  ->  obj pointer = (fun ( l  :  struct_typ ) ( p  :  obj pointer ) ( fd  :  struct_field ) -> (

let uu___ = p
in (match (uu___) with
| Pointer (from, contents, p') -> begin
(

let p'1 = p'
in (

let p'' = PathStep (TStruct (l), (typ_of_struct_field l fd), p'1, StepField (l, fd))
in Pointer (from, contents, p'')))
end)))


let _cell : array_length_t  ->  typ  ->  obj pointer  ->  FStar_UInt32.t  ->  obj pointer = (fun ( length  :  array_length_t ) ( value  :  typ ) ( p  :  obj pointer ) ( i  :  FStar_UInt32.t ) -> (

let uu___ = p
in (match (uu___) with
| Pointer (from, contents, p') -> begin
(

let p'1 = p'
in (

let p'' = PathStep (TArray (length, value), value, p'1, StepCell (length, value, i))
in Pointer (from, contents, p'')))
end)))


let _ufield : union_typ  ->  obj pointer  ->  struct_field  ->  obj pointer = (fun ( l  :  union_typ ) ( p  :  obj pointer ) ( fd  :  struct_field ) -> (

let uu___ = p
in (match (uu___) with
| Pointer (from, contents, p') -> begin
(

let p'1 = p'
in (

let p'' = PathStep (TUnion (l), (typ_of_struct_field l fd), p'1, StepUField (l, fd))
in Pointer (from, contents, p'')))
end)))



type pointer_ref_contents =
(typ, obj) Prims.dtuple2





type readable_struct_fields' =
obj




type equal_values =
unit


let _singleton_buffer_of_pointer : typ  ->  obj pointer  ->  obj buffer = (fun ( t  :  typ ) ( p  :  obj pointer ) -> (

let uu___ = p
in (match (uu___) with
| Pointer (from, contents, pth) -> begin
(match (pth) with
| PathStep (uu___1, uu___2, pth', StepCell (ln, ty, i)) -> begin
Buffer (BufferRootArray (ln, Pointer (from, contents, pth')), i, (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))))
end
| uu___1 -> begin
Buffer (BufferRootSingleton (p), (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (FStar_UInt32.uint_to_t ((Prims.parse_int "1"))))
end)
end)))


let singleton_buffer_of_pointer : typ  ->  obj pointer  ->  obj buffer = (fun ( t  :  typ ) ( p  :  obj pointer ) -> (_singleton_buffer_of_pointer t p))


let buffer_of_array_pointer : typ  ->  array_length_t  ->  obj pointer  ->  obj buffer = (fun ( t  :  typ ) ( length  :  array_length_t ) ( p  :  obj pointer ) -> Buffer (BufferRootArray (length, p), (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), length))




let sub_buffer : typ  ->  obj buffer  ->  FStar_UInt32.t  ->  FStar_UInt32.t  ->  obj buffer = (fun ( t  :  typ ) ( b  :  obj buffer ) ( i  :  FStar_UInt32.t ) ( len  :  FStar_UInt32.t ) -> Buffer ((__proj__Buffer__item__broot t b), (FStar_UInt32.add (__proj__Buffer__item__bidx t b) i), len))


let offset_buffer : typ  ->  obj buffer  ->  FStar_UInt32.t  ->  obj buffer = (fun ( t  :  typ ) ( b  :  obj buffer ) ( i  :  FStar_UInt32.t ) -> (sub_buffer t b i (FStar_UInt32.sub (__proj__Buffer__item__blength t b) i)))


let pointer_of_buffer_cell : typ  ->  obj buffer  ->  FStar_UInt32.t  ->  obj pointer = (fun ( t  :  typ ) ( b  :  obj buffer ) ( i  :  FStar_UInt32.t ) -> (match ((__proj__Buffer__item__broot t b)) with
| BufferRootSingleton (p) -> begin
p
end
| BufferRootArray (uu___, p) -> begin
(_cell uu___ t p (FStar_UInt32.add (__proj__Buffer__item__bidx t b) i))
end))


type buffer_readable' =
unit



type disjoint =
obj

type loc_aux =
| LocBuffer of typ * obj buffer
| LocPointer of typ * obj pointer


let uu___is_LocBuffer : loc_aux  ->  Prims.bool = (fun ( projectee  :  loc_aux ) -> (match (projectee) with
| LocBuffer (t, b) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__LocBuffer__item__t : loc_aux  ->  typ = (fun ( projectee  :  loc_aux ) -> (match (projectee) with
| LocBuffer (t, b) -> begin
t
end))


let __proj__LocBuffer__item__b : loc_aux  ->  obj buffer = (fun ( projectee  :  loc_aux ) -> (match (projectee) with
| LocBuffer (t, b) -> begin
b
end))


let uu___is_LocPointer : loc_aux  ->  Prims.bool = (fun ( projectee  :  loc_aux ) -> (match (projectee) with
| LocPointer (t, p) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__LocPointer__item__t : loc_aux  ->  typ = (fun ( projectee  :  loc_aux ) -> (match (projectee) with
| LocPointer (t, p) -> begin
t
end))


let __proj__LocPointer__item__p : loc_aux  ->  obj pointer = (fun ( projectee  :  loc_aux ) -> (match (projectee) with
| LocPointer (t, p) -> begin
p
end))


type buffer_includes_pointer =
unit


type loc_aux_includes_pointer =
obj


type loc_aux_includes_buffer =
unit


type loc_aux_includes =
obj


type disjoint_buffer_vs_pointer =
unit


type loc_aux_disjoint_pointer =
obj


type loc_aux_disjoint_buffer =
unit


type loc_aux_disjoint =
obj


type pointer_preserved =
unit


type buffer_preserved =
unit


type loc_aux_preserved =
obj


type loc_aux_in_addr =
obj


type aloc =
loc_aux


type loc =
unit








type modifies_0 =
unit


type modifies_1 =
unit


let screate : typ  ->  obj FStar_Pervasives_Native.option  ->  obj pointer = (fun ( value  :  typ ) ( s  :  obj FStar_Pervasives_Native.option ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (

let s1 = (match (s) with
| FStar_Pervasives_Native.Some (s2) -> begin
(ovalue_of_value value s2)
end
| uu___ -> begin
(none_ovalue value)
end)
in (

let content = (FStar_HyperStack_ST.salloc (Prims.Mkdtuple2 (value, s1)))
in (

let aref = (FStar_Monotonic_HyperStack.aref_of content)
in (

let p = Pointer (value, aref, PathBase)
in (

let h1 = (FStar_HyperStack_ST.get ())
in p)))))))


let ecreate : typ  ->  unit  ->  obj FStar_Pervasives_Native.option  ->  obj pointer = (fun ( t  :  typ ) ( r  :  unit ) ( s  :  obj FStar_Pervasives_Native.option ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (

let s0 = s
in (

let s1 = (match (s) with
| FStar_Pervasives_Native.Some (s2) -> begin
(ovalue_of_value t s2)
end
| uu___ -> begin
(none_ovalue t)
end)
in (

let content = (FStar_HyperStack_ST.ralloc () (Prims.Mkdtuple2 (t, s1)))
in (

let aref = (FStar_Monotonic_HyperStack.aref_of content)
in (

let p = Pointer (t, aref, PathBase)
in (

let h1 = (FStar_HyperStack_ST.get ())
in p))))))))


let field : struct_typ  ->  obj pointer  ->  struct_field  ->  obj pointer = (fun ( l  :  struct_typ ) ( p  :  obj pointer ) ( fd  :  struct_field ) -> (_field l p fd))


let ufield : union_typ  ->  obj pointer  ->  struct_field  ->  obj pointer = (fun ( l  :  union_typ ) ( p  :  obj pointer ) ( fd  :  struct_field ) -> (_ufield l p fd))


let cell : array_length_t  ->  typ  ->  obj pointer  ->  FStar_UInt32.t  ->  obj pointer = (fun ( length  :  array_length_t ) ( value  :  typ ) ( p  :  obj pointer ) ( i  :  FStar_UInt32.t ) -> (_cell length value p i))


let reference_of : typ  ->  FStar_Monotonic_HyperStack.mem  ->  obj pointer  ->  pointer_ref_contents FStar_HyperStack.reference = (fun ( value  :  typ ) ( h  :  FStar_Monotonic_HyperStack.mem ) ( p  :  obj pointer ) -> (

let x = (Prims.unsafe_coerce (FStar_Monotonic_HyperStack.reference_of h (__proj__Pointer__item__contents value p) () ()))
in x))


let read : typ  ->  obj pointer  ->  obj = (fun ( value  :  typ ) ( p  :  obj pointer ) -> (

let h = (FStar_HyperStack_ST.get ())
in (

let r = (reference_of value h p)
in ((FStar_HyperStack_ST.witness_region ());
(FStar_HyperStack_ST.witness_hsref r);
(

let uu___2 = (FStar_HyperStack_ST.op_Bang r)
in (match (uu___2) with
| Prims.Mkdtuple2 (uu___3, c) -> begin
(value_of_ovalue value (path_sel uu___3 value c (__proj__Pointer__item__p value p)))
end));
))))


let is_null : typ  ->  obj npointer  ->  Prims.bool = (fun ( t  :  typ ) ( p  :  obj npointer ) -> (match (p) with
| NullPtr -> begin
true
end
| uu___ -> begin
false
end))


let owrite : typ  ->  obj pointer  ->  obj  ->  unit = (fun ( a  :  typ ) ( b  :  obj pointer ) ( z  :  obj ) -> (

let h0 = (FStar_HyperStack_ST.get ())
in (

let r = (reference_of a h0 b)
in ((FStar_HyperStack_ST.witness_region ());
(FStar_HyperStack_ST.witness_hsref r);
(

let v0 = (FStar_HyperStack_ST.op_Bang r)
in (

let uu___2 = v0
in (match (uu___2) with
| Prims.Mkdtuple2 (t, c0) -> begin
(

let c1 = (path_upd t a c0 (__proj__Pointer__item__p a b) z)
in (

let v1 = Prims.Mkdtuple2 (t, c1)
in ((FStar_HyperStack_ST.op_Colon_Equals r v1);
(

let h1 = (FStar_HyperStack_ST.get ())
in ());
)))
end)));
))))


let write : typ  ->  obj pointer  ->  obj  ->  unit = (fun ( a  :  typ ) ( b  :  obj pointer ) ( z  :  obj ) -> (owrite a b (ovalue_of_value a z)))


let write_union_field : union_typ  ->  obj pointer  ->  struct_field  ->  unit = (fun ( l  :  union_typ ) ( p  :  obj pointer ) ( fd  :  struct_field ) -> (

let field_t = (typ_of_struct_field l fd)
in (

let vu = FStar_Pervasives_Native.Some ((gtdata_create fd (none_ovalue field_t)))
in (

let vu1 = (Prims.unsafe_coerce vu)
in (owrite (TUnion (l)) p vu1)))))


let read_buffer : typ  ->  obj buffer  ->  FStar_UInt32.t  ->  obj = (fun ( t  :  typ ) ( b  :  obj buffer ) ( i  :  FStar_UInt32.t ) -> (

let uu___ = (pointer_of_buffer_cell t b i)
in (read t uu___)))


let write_buffer : typ  ->  obj buffer  ->  FStar_UInt32.t  ->  obj  ->  unit = (fun ( t  :  typ ) ( b  :  obj buffer ) ( i  :  FStar_UInt32.t ) ( v  :  obj ) -> (

let uu___ = (pointer_of_buffer_cell t b i)
in (write t uu___ v)))









