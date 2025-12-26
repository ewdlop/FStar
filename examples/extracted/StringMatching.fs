#light "off"
module StringMatching

type 't str =
't FStar_Seq_Base.seq


type is_prefix =
unit


type is_suffix =
unit


type occurs_at =
unit


let rec find_in_range : Prims.nat  ->  Prims.nat  ->  (Prims.nat  ->  Prims.bool)  ->  Prims.nat FStar_Pervasives_Native.option = (fun ( i  :  Prims.nat ) ( j  :  Prims.nat ) ( body  :  Prims.nat  ->  Prims.bool ) -> (match ((body i)) with
| true -> begin
FStar_Pervasives_Native.Some (i)
end
| uu___ -> begin
(match ((Prims.op_Equality i j)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___1 -> begin
(find_in_range (i + (Prims.parse_int "1")) j body)
end)
end))


let naive_string_matcher = (fun ( x  :  't str ) ( pattern  :  't str ) -> (

let n = (FStar_Seq_Base.length x)
in (

let m = (FStar_Seq_Base.length pattern)
in (match ((n < m)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___ -> begin
(find_in_range (Prims.parse_int "0") (n - m) (fun ( i  :  Prims.nat ) -> (Prims.op_Equality pattern (FStar_Seq_Base.slice x i (i + m)))))
end))))


let rec hash : Prims.nat str  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat = (fun ( x  :  Prims.nat str ) ( base1  :  Prims.nat ) ( prime  :  Prims.nat ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) -> (match ((Prims.op_Equality i j)) with
| true -> begin
(Prims.parse_int "0")
end
| uu___ -> begin
(

let lsd = (FStar_Seq_Base.index x (j - (Prims.parse_int "1")))
in (

let h = (hash x base1 prime i (j - (Prims.parse_int "1")))
in (Prims.mod_f ((base1 * h) + lsd) prime)))
end))


let rec pow : Prims.nat  ->  Prims.nat  ->  Prims.nat = (fun ( base1  :  Prims.nat ) ( m  :  Prims.nat ) -> (match ((Prims.op_Equality m (Prims.parse_int "0"))) with
| true -> begin
(Prims.parse_int "1")
end
| uu___ -> begin
((pow base1 (m - (Prims.parse_int "1"))) * base1)
end))


let remove_msd : Prims.nat str  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat = (fun ( x  :  Prims.nat str ) ( base1  :  Prims.nat ) ( prime  :  Prims.nat ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) ( h  :  Prims.nat ) ( pow_base_m  :  Prims.nat ) -> (

let msd = (FStar_Seq_Base.index x i)
in (Prims.mod_f (h - (msd * pow_base_m)) prime)))


let add_lsd : Prims.nat str  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat = (fun ( x  :  Prims.nat str ) ( base1  :  Prims.nat ) ( prime  :  Prims.nat ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) ( h  :  Prims.nat ) ( pow_base_m  :  Prims.nat ) -> (

let lsd = (FStar_Seq_Base.index x j)
in (Prims.mod_f ((base1 * h) + lsd) prime)))


let rolling_hash : Prims.nat str  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat = (fun ( x  :  Prims.nat str ) ( base1  :  Prims.nat ) ( prime  :  Prims.nat ) ( i  :  Prims.nat ) ( j  :  Prims.nat ) ( h  :  Prims.nat ) ( pow_base_m  :  Prims.nat ) -> (

let h0 = (remove_msd x base1 prime i j h pow_base_m)
in (

let res = (add_lsd x base1 prime (i + (Prims.parse_int "1")) j h0 pow_base_m)
in res)))


type eq_sub_seq =
unit


type maybe_found =
obj


let rabin_karp_matcher_nat : Prims.nat str  ->  Prims.nat str  ->  Prims.nat  ->  Prims.nat  ->  Prims.nat FStar_Pervasives_Native.option = (fun ( xs  :  Prims.nat str ) ( pat  :  Prims.nat str ) ( base1  :  Prims.nat ) ( prime  :  Prims.nat ) -> (

let m = (FStar_Seq_Base.length pat)
in (

let n = (FStar_Seq_Base.length xs)
in (match ((n < m)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___ -> begin
(match ((Prims.op_Equality m (Prims.parse_int "0"))) with
| true -> begin
FStar_Pervasives_Native.Some ((Prims.parse_int "0"))
end
| uu___1 -> begin
(

let pow_base_m = (pow base1 (m - (Prims.parse_int "1")))
in (

let hpat = (hash pat base1 prime (Prims.parse_int "0") m)
in (

let xpat = (hash xs base1 prime (Prims.parse_int "0") m)
in (

let rec loop : Prims.nat  ->  Prims.nat  ->  Prims.nat FStar_Pervasives_Native.option = (fun ( i  :  Prims.nat ) ( xpat1  :  Prims.nat ) -> (

let found = (match ((Prims.op_Equality xpat1 hpat)) with
| true -> begin
(Prims.op_Equality pat (FStar_Seq_Base.slice xs i (i + m)))
end
| uu___2 -> begin
false
end)
in (match (found) with
| true -> begin
FStar_Pervasives_Native.Some (i)
end
| uu___2 -> begin
(match ((Prims.op_Equality i (n - m))) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___3 -> begin
(

let xnext = (rolling_hash xs base1 prime i (i + m) xpat1 pow_base_m)
in (loop (i + (Prims.parse_int "1")) xnext))
end)
end)))
in (loop (Prims.parse_int "0") xpat)))))
end)
end))))


let rabin_karp_matcher = (fun ( t_xs  :  't str ) ( t_pat  :  't str ) ( as_digit  :  't  ->  Prims.nat ) ( base1  :  Prims.nat ) ( prime  :  Prims.nat ) -> (

let m = (FStar_Seq_Base.length t_pat)
in (

let n = (FStar_Seq_Base.length t_xs)
in (match ((n < m)) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___ -> begin
(match ((Prims.op_Equality m (Prims.parse_int "0"))) with
| true -> begin
FStar_Pervasives_Native.Some ((Prims.parse_int "0"))
end
| uu___1 -> begin
(

let pow_base_m = (pow base1 (m - (Prims.parse_int "1")))
in (

let pat = (FStar_Seq_Properties.map_seq as_digit t_pat)
in (

let xs = (FStar_Seq_Properties.map_seq as_digit t_xs)
in (

let hpat = (hash pat base1 prime (Prims.parse_int "0") m)
in (

let xpat = (hash xs base1 prime (Prims.parse_int "0") m)
in (

let rec loop : Prims.nat  ->  Prims.nat  ->  Prims.nat FStar_Pervasives_Native.option = (fun ( i  :  Prims.nat ) ( xpat1  :  Prims.nat ) -> (

let found = (match ((Prims.op_Equality xpat1 hpat)) with
| true -> begin
(Prims.op_Equality t_pat (FStar_Seq_Base.slice t_xs i (i + m)))
end
| uu___2 -> begin
false
end)
in (match (found) with
| true -> begin
FStar_Pervasives_Native.Some (i)
end
| uu___2 -> begin
(match ((Prims.op_Equality i (n - m))) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___3 -> begin
(

let xnext = (rolling_hash xs base1 prime i (i + m) xpat1 pow_base_m)
in (loop (i + (Prims.parse_int "1")) xnext))
end)
end)))
in (loop (Prims.parse_int "0") xpat)))))))
end)
end))))




