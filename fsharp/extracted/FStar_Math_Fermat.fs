#light "off"
module FStar_Math_Fermat

let rec pow : Prims.int  ->  Prims.nat  ->  Prims.int = (fun ( a  :  Prims.int ) ( k  :  Prims.nat ) -> (match ((Prims.op_Equality k (Prims.parse_int "0"))) with
| true -> begin
(Prims.parse_int "1")
end
| uu___ -> begin
(a * (pow a (k - (Prims.parse_int "1"))))
end))


let rec binomial : Prims.nat  ->  Prims.nat  ->  Prims.nat = (fun ( n  :  Prims.nat ) ( k  :  Prims.nat ) -> (match (((n), (k))) with
| (uu___, uu___1) when (uu___1 = (Prims.parse_int "0")) -> begin
(Prims.parse_int "1")
end
| (uu___, uu___1) when (uu___ = (Prims.parse_int "0")) -> begin
(Prims.parse_int "0")
end
| (uu___, uu___1) -> begin
((binomial (n - (Prims.parse_int "1")) k) + (binomial (n - (Prims.parse_int "1")) (k - (Prims.parse_int "1"))))
end))


let rec factorial : Prims.nat  ->  Prims.pos = (fun ( uu___  :  Prims.nat ) -> (match (uu___) with
| uu___1 when (uu___1 = (Prims.parse_int "0")) -> begin
(Prims.parse_int "1")
end
| n -> begin
(n * (factorial (n - (Prims.parse_int "1"))))
end))


let op_Bang : Prims.nat  ->  Prims.pos = (fun ( n  :  Prims.nat ) -> (factorial n))


let rec sum : Prims.nat  ->  Prims.nat  ->  (Prims.nat  ->  Prims.int)  ->  Prims.int = (fun ( a  :  Prims.nat ) ( b  :  Prims.nat ) ( f  :  Prims.nat  ->  Prims.int ) -> (match ((Prims.op_Equality a b)) with
| true -> begin
(f a)
end
| uu___ -> begin
((f a) + (sum (a + (Prims.parse_int "1")) b f))
end))




