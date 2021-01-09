func @_ProgettoBirra.ProdottoMapper.getNome$$() -> none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :25 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :27 :19) // Not a variable of known type: nome
return %0 : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :27 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.ProdottoMapper.getQuantita$$() -> none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :30 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :32 :19) // Not a variable of known type: quantita
return %0 : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :32 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.ProdottoMapper.setNome$string$(none) -> () loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :36 :8) {
^entry (%_nome : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :36 :28)
cbde.store %_nome, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :36 :28)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :38 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :38 :12) // this.nome (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :38 :24) // Not a variable of known type: nome
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.ProdottoMapper.setQuantita$string$(none) -> () loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :41 :8) {
^entry (%_quantita : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :41 :32)
cbde.store %_quantita, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :41 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :43 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :43 :12) // this.quantita (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\progettoBirra\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :43 :28) // Not a variable of known type: quantita
br ^1

^1: // ExitBlock
return

}
