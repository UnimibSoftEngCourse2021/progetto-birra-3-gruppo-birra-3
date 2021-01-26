func @_ProgettoBirra.ProdottoMapper.getNome$$() -> none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :19 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :21 :19) // Not a variable of known type: nome
return %0 : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :21 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.ProdottoMapper.getQuantita$$() -> none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :24 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :26 :19) // Not a variable of known type: quantita
return %0 : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :26 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.ProdottoMapper.setNome$string$(none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :30 :8) {
^entry (%_nome : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :30 :28)
cbde.store %_nome, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :30 :28)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :32 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :32 :12) // this.nome (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :32 :24) // Not a variable of known type: nome
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.ProdottoMapper.setQuantita$string$(none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :35 :8) {
^entry (%_quantita : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :35 :32)
cbde.store %_quantita, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :35 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :37 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :37 :12) // this.quantita (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ProdottoMapper.cs" :37 :28) // Not a variable of known type: quantita
br ^1

^1: // ExitBlock
return

}
