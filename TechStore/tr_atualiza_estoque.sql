create trigger tr_baixa_de_estoque on entrada after insert as
begin
update entrada
set quantidade = quantidade + quantidade
where identrada = identrada;
end
