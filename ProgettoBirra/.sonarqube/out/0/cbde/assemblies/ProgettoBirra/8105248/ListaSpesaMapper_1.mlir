func @_ProgettoBirra.ListaSpesaMapper.getnomeProd$$() -> none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :17 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :19 :19) // Not a variable of known type: nomeProd
return %0 : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :19 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.ListaSpesaMapper.getQuantita$$() -> none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :22 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :24 :19) // Not a variable of known type: quantita
return %0 : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :24 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_ProgettoBirra.ListaSpesaMapper.setnomeProd$string$(none) -> () loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :27 :8) {
^entry (%_nomeProd : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :27 :32)
cbde.store %_nomeProd, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :27 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :29 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :29 :12) // this.nomeProd (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :29 :28) // Not a variable of known type: nomeProd
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.ListaSpesaMapper.setQuantita$string$(none) -> () loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :31 :8) {
^entry (%_quantita : none):
%0 = cbde.alloca none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :31 :32)
cbde.store %_quantita, %0 : memref<none> loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :31 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :33 :12) // this (ThisExpression)
%2 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :33 :12) // this.quantita (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\aless\\Desktop\\Progetto\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\ListaSpesaMapper.cs" :33 :28) // Not a variable of known type: quantita
br ^1

^1: // ExitBlock
return

}
