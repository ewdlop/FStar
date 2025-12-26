#light "off"
module FStar_Algebra_CommMonoid_Fold

let init_func_from_expr = (fun ( n0  :  Prims.int ) ( nk  :  FStar_IntegerIntervals.not_less_than ) ( expr  :  FStar_IntegerIntervals.ifrom_ito  ->  'c ) ( a  :  FStar_IntegerIntervals.ifrom_ito ) ( b  :  FStar_IntegerIntervals.ifrom_ito ) ( i  :  FStar_IntegerIntervals.counter_for ) -> (expr (n0 + i)))


let rec fold = (fun ( eq  :  'c FStar_Algebra_CommMonoid_Equiv.equiv ) ( cm  :  ('c, obj) FStar_Algebra_CommMonoid_Equiv.cm ) ( a  :  Prims.int ) ( b  :  FStar_IntegerIntervals.not_less_than ) ( expr  :  FStar_IntegerIntervals.ifrom_ito  ->  'c ) -> (match ((Prims.op_Equality b a)) with
| true -> begin
(expr b)
end
| uu___ -> begin
(FStar_Algebra_CommMonoid_Equiv.__proj__CM__item__mult eq cm (fold eq cm a (b - (Prims.parse_int "1")) expr) (expr b))
end))




