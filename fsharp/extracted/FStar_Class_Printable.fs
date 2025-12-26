#light "off"
module FStar_Class_Printable
type 'a printable =
{to_string : 'a  ->  Prims.string}


let __proj__Mkprintable__item__to_string = (fun ( projectee  :  'a printable ) -> (match (projectee) with
| {to_string = to_string} -> begin
to_string
end))


let to_string = (fun ( projectee  :  'a printable ) -> (match (projectee) with
| {to_string = to_string1} -> begin
to_string1
end))


let printable_unit : unit printable = {to_string = (fun ( uu___  :  unit ) -> "()")}


let printable_bool : Prims.bool printable = {to_string = Prims.string_of_bool}


let printable_nat : Prims.nat printable = {to_string = Prims.string_of_int}


let printable_int : Prims.int printable = {to_string = Prims.string_of_int}


let printable_ref = (fun ( d  :  'a printable ) -> {to_string = d.to_string})


let printable_list = (fun ( x  :  'a printable ) -> {to_string = (fun ( l  :  'a Prims.list ) -> (Prims.strcat "[" (Prims.strcat (FStar_String.concat "; " (FStar_List_Tot_Base.map (to_string x) l)) "]")))})


let printable_string : Prims.string printable = {to_string = (fun ( x  :  Prims.string ) -> (Prims.strcat "\"" (Prims.strcat x "\"")))}


let printable_option = (fun ( uu___  :  'a printable ) -> {to_string = (fun ( uu___1  :  'a FStar_Pervasives_Native.option ) -> (match (uu___1) with
| FStar_Pervasives_Native.None -> begin
"None"
end
| FStar_Pervasives_Native.Some (x) -> begin
(Prims.strcat "(Some " (Prims.strcat (to_string uu___ x) ")"))
end))})


let printable_either = (fun ( uu___  :  'a printable ) ( uu___1  :  'b printable ) -> {to_string = (fun ( uu___2  :  ('a, 'b) FStar_Pervasives.either ) -> (match (uu___2) with
| FStar_Pervasives.Inl (x) -> begin
(Prims.strcat "(Inl " (Prims.strcat (to_string uu___ x) ")"))
end
| FStar_Pervasives.Inr (x) -> begin
(Prims.strcat "(Inr " (Prims.strcat (to_string uu___1 x) ")"))
end))})


let printable_char : FStar_Char.char printable = {to_string = FStar_String.string_of_char}


let printable_byte : FStar_UInt8.t printable = {to_string = FStar_UInt8.to_string}


let printable_int8 : FStar_Int8.t printable = {to_string = FStar_Int8.to_string}


let printable_uint8 : FStar_UInt8.t printable = {to_string = FStar_UInt8.to_string}


let printable_int16 : FStar_Int16.t printable = {to_string = FStar_Int16.to_string}


let printable_uint16 : FStar_UInt16.t printable = {to_string = FStar_UInt16.to_string}


let printable_int32 : FStar_Int32.t printable = {to_string = FStar_Int32.to_string}


let printable_uint32 : FStar_UInt32.t printable = {to_string = FStar_UInt32.to_string}


let printable_int64 : FStar_Int64.t printable = {to_string = FStar_Int64.to_string}


let printable_uint64 : FStar_UInt64.t printable = {to_string = FStar_UInt64.to_string}


let printable_tuple2 = (fun ( uu___  :  'a printable ) ( uu___1  :  'b printable ) -> {to_string = (fun ( uu___2  :  ('a * 'b) ) -> (match (uu___2) with
| (x, y) -> begin
(Prims.strcat "(" (Prims.strcat (to_string uu___ x) (Prims.strcat ", " (Prims.strcat (to_string uu___1 y) ")"))))
end))})


let printable_tuple3 = (fun ( uu___  :  't0 printable ) ( uu___1  :  't1 printable ) ( uu___2  :  't2 printable ) -> {to_string = (fun ( uu___3  :  ('t0 * 't1 * 't2) ) -> (match (uu___3) with
| (v0, v1, v2) -> begin
(Prims.strcat "(" (Prims.strcat (to_string uu___ v0) (Prims.strcat ", " (Prims.strcat (to_string uu___1 v1) (Prims.strcat ", " (Prims.strcat (to_string uu___2 v2) ")"))))))
end))})


let printable_tuple4 = (fun ( uu___  :  't0 printable ) ( uu___1  :  't1 printable ) ( uu___2  :  't2 printable ) ( uu___3  :  't3 printable ) -> {to_string = (fun ( uu___4  :  ('t0 * 't1 * 't2 * 't3) ) -> (match (uu___4) with
| (v0, v1, v2, v3) -> begin
(Prims.strcat "(" (Prims.strcat (to_string uu___ v0) (Prims.strcat ", " (Prims.strcat (to_string uu___1 v1) (Prims.strcat ", " (Prims.strcat (to_string uu___2 v2) (Prims.strcat ", " (Prims.strcat (to_string uu___3 v3) ")"))))))))
end))})


let printable_tuple5 = (fun ( uu___  :  't0 printable ) ( uu___1  :  't1 printable ) ( uu___2  :  't2 printable ) ( uu___3  :  't3 printable ) ( uu___4  :  't4 printable ) -> {to_string = (fun ( uu___5  :  ('t0 * 't1 * 't2 * 't3 * 't4) ) -> (match (uu___5) with
| (v0, v1, v2, v3, v4) -> begin
(Prims.strcat "(" (Prims.strcat (to_string uu___ v0) (Prims.strcat ", " (Prims.strcat (to_string uu___1 v1) (Prims.strcat ", " (Prims.strcat (to_string uu___2 v2) (Prims.strcat ", " (Prims.strcat (to_string uu___3 v3) (Prims.strcat ", " (Prims.strcat (to_string uu___4 v4) ")"))))))))))
end))})


let printable_tuple6 = (fun ( uu___  :  't0 printable ) ( uu___1  :  't1 printable ) ( uu___2  :  't2 printable ) ( uu___3  :  't3 printable ) ( uu___4  :  't4 printable ) ( uu___5  :  't5 printable ) -> {to_string = (fun ( uu___6  :  ('t0 * 't1 * 't2 * 't3 * 't4 * 't5) ) -> (match (uu___6) with
| (v0, v1, v2, v3, v4, v5) -> begin
(Prims.strcat "(" (Prims.strcat (to_string uu___ v0) (Prims.strcat ", " (Prims.strcat (to_string uu___1 v1) (Prims.strcat ", " (Prims.strcat (to_string uu___2 v2) (Prims.strcat ", " (Prims.strcat (to_string uu___3 v3) (Prims.strcat ", " (Prims.strcat (to_string uu___4 v4) (Prims.strcat ", " (Prims.strcat (to_string uu___5 v5) ")"))))))))))))
end))})


let printable_tuple7 = (fun ( uu___  :  't0 printable ) ( uu___1  :  't1 printable ) ( uu___2  :  't2 printable ) ( uu___3  :  't3 printable ) ( uu___4  :  't4 printable ) ( uu___5  :  't5 printable ) ( uu___6  :  't6 printable ) -> {to_string = (fun ( uu___7  :  ('t0 * 't1 * 't2 * 't3 * 't4 * 't5 * 't6) ) -> (match (uu___7) with
| (v0, v1, v2, v3, v4, v5, v6) -> begin
(Prims.strcat "(" (Prims.strcat (to_string uu___ v0) (Prims.strcat ", " (Prims.strcat (to_string uu___1 v1) (Prims.strcat ", " (Prims.strcat (to_string uu___2 v2) (Prims.strcat ", " (Prims.strcat (to_string uu___3 v3) (Prims.strcat ", " (Prims.strcat (to_string uu___4 v4) (Prims.strcat ", " (Prims.strcat (to_string uu___5 v5) (Prims.strcat ", " (Prims.strcat (to_string uu___6 v6) ")"))))))))))))))
end))})


let printable_seq = (fun ( x  :  'b printable ) -> {to_string = (fun ( s  :  'b FStar_Seq_Base.seq ) -> (

let strings_of_b = (FStar_Seq_Properties.map_seq (to_string x) s)
in (Prims.strcat "<" (Prims.strcat (FStar_String.concat "; " (FStar_Seq_Base.seq_to_list strings_of_b)) ">"))))})




