// Skipping function buttonFine_Click(none, none), it contains poisonous unsupported syntaxes

func @_ProgettoBirra.FormAggiungiProdottiRicetta.buttonSalva_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :46 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :46 :39)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :46 :39)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :46 :54)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :46 :54)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :48 :17) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :48 :38) // Not a variable of known type: nomeRic
%4 = cbde.unknown : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :48 :17) // database.verificaRic(nomeRic) (InvocationExpression)
%5 = cbde.unknown : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :48 :16) // !database.verificaRic(nomeRic) (LogicalNotExpression)
cond_br %5, ^1, ^2 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :48 :16)

^1: // SimpleBlock
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :49 :16) // Not a variable of known type: database
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :49 :35) // Not a variable of known type: nomeRic
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :49 :44) // Not a variable of known type: attRic
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :49 :52) // Not a variable of known type: prepRic
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :49 :61) // Not a variable of known type: noteRic
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :49 :16) // database.InsertRic(nomeRic, attRic, prepRic, noteRic) (InvocationExpression)
br ^2

^2: // SimpleBlock
%12 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :51 :28) // Not a variable of known type: database
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :51 :51) // Not a variable of known type: nomeRic
%14 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :51 :28) // database.recuperoIdRic(nomeRic) (InvocationExpression)
%15 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :51 :16) // idRicetta
cbde.store %14, %15 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :51 :16)
%16 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :12) // Not a variable of known type: database
%17 = cbde.load %15 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :35)
%18 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :46) // Not a variable of known type: textBox1
%19 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :46) // textBox1.Text (SimpleMemberAccessExpression)
// Entity from another assembly: Int32
%20 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :73) // Not a variable of known type: textBox2
%21 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :73) // textBox2.Text (SimpleMemberAccessExpression)
%22 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :61) // Int32.Parse(textBox2.Text) (InvocationExpression)
%23 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :53 :12) // database.InsertProdRic(idRicetta, textBox1.Text, Int32.Parse(textBox2.Text)) (InvocationExpression)
%24 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :55 :12) // Not a variable of known type: textBox1
%25 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :55 :12) // textBox1.Text (SimpleMemberAccessExpression)
%26 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :55 :28) // "" (StringLiteralExpression)
%27 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :56 :12) // Not a variable of known type: textBox2
%28 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :56 :12) // textBox2.Text (SimpleMemberAccessExpression)
%29 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormAggiungiProdottiRicetta.cs" :56 :28) // "" (StringLiteralExpression)
br ^3

^3: // ExitBlock
return

}
