func @_ProgettoBirra.FormRicetta.buttonElimina_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :38 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :38 :41)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :38 :41)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :38 :56)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :38 :56)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :40 :24) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :40 :47) // Not a variable of known type: textBoxNome
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :40 :47) // textBoxNome.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :40 :24) // database.recuperoIdRic(textBoxNome.Text) (InvocationExpression)
%6 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :40 :16) // idRic
cbde.store %5, %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :40 :16)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :42 :12) // Not a variable of known type: database
%8 = cbde.load %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :42 :35)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :42 :12) // database.DeleteProdRic(idRic) (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :43 :12) // Not a variable of known type: database
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :43 :31) // Not a variable of known type: textBoxNome
%12 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :43 :31) // textBoxNome.Text (SimpleMemberAccessExpression)
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :43 :12) // database.DeleteRic(textBoxNome.Text) (InvocationExpression)
// Entity from another assembly: MessageBox
%14 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :44 :28) // "La ricetta è stata eliminata dal ricettario" (StringLiteralExpression)
%15 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :44 :12) // MessageBox.Show("La ricetta è stata eliminata dal ricettario") (InvocationExpression)
%16 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :47 :12) // this (ThisExpression)
%17 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :47 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormRicetta.textBoxProdotti_TextChanged$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :50 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :50 :49)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :50 :49)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :50 :64)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :50 :64)
br ^0

^0: // ExitBlock
return

}
func @_ProgettoBirra.FormRicetta.buttonModificaRic_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :55 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :55 :45)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :55 :45)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :55 :60)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :55 :60)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :31) // Not a variable of known type: textBoxNome
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :31) // textBoxNome.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :49) // Not a variable of known type: textBoxNote
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :49) // textBoxNote.Text (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :12) // database.UpdateRic(textBoxNome.Text, textBoxNote.Text) (InvocationExpression)
// Entity from another assembly: MessageBox
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :58 :28) // "La nota è stata modificata con successo" (StringLiteralExpression)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :58 :12) // MessageBox.Show("La nota è stata modificata con successo") (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :61 :12) // this (ThisExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :61 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormRicetta.buttonPrepara$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :64 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :64 :35)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :64 :35)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :64 :50)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :64 :50)
br ^0

^0: // ForInitializerBlock
%2 = constant 1 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :66 :25) // true
%3 = cbde.alloca i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :66 :17) // fatta
cbde.store %2, %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :66 :17)
%4 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :67 :16) // numero
%5 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :16) // quantitaDaTogliere
%6 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :69 :16) // quantitaVecchia
%7 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :25)
%8 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :21) // i
cbde.store %7, %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :21)
br ^1

^1: // BinaryBranchBlock
%9 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :28)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :32) // Globals.listaProdotti (SimpleMemberAccessExpression)
%11 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :32) // Globals.listaProdotti.Count (SimpleMemberAccessExpression)
%12 = cmpi "slt", %9, %11 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :28)
cond_br %12, ^2, ^3 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :28)

^2: // BinaryBranchBlock
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :20) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%14 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :42) // Globals.listaProdotti (SimpleMemberAccessExpression)
%15 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :64)
%16 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :42) // Globals.listaProdotti[i] (ElementAccessExpression)
%17 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :42) // Globals.listaProdotti[i].getNome() (InvocationExpression)
%18 = cbde.unknown : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :20) // database.verificaProd(Globals.listaProdotti[i].getNome()) (InvocationExpression)
%19 = constant 0 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :81) // false
%20 = cmpi "eq", %18, %19 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :20)
cond_br %20, ^4, ^5 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :20)

^4: // JumpBlock
// Entity from another assembly: MessageBox
%21 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :76 :36) // "Impossibile preparare ricetta, non hai i prodotti necessari" (StringLiteralExpression)
%22 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :76 :20) // MessageBox.Show("Impossibile preparare ricetta, non hai i prodotti necessari") (InvocationExpression)
%23 = constant 0 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :28) // false
cbde.store %23, %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :20)
br ^3 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :20) // break

^5: // BinaryBranchBlock
// Entity from another assembly: Convert
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%24 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :81 :41) // Globals.listaProdotti (SimpleMemberAccessExpression)
%25 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :81 :63)
%26 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :81 :41) // Globals.listaProdotti[i] (ElementAccessExpression)
%27 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :81 :41) // Globals.listaProdotti[i].getQuantita() (InvocationExpression)
%28 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :81 :25) // Convert.ToInt32(Globals.listaProdotti[i].getQuantita()) (InvocationExpression)
cbde.store %28, %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :81 :16)
%29 = cbde.load %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :25)
// Entity from another assembly: Convert
%30 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :51) // this (ThisExpression)
%31 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :51) // this.numericUpDown1 (SimpleMemberAccessExpression)
%32 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :51) // this.numericUpDown1.Text (SimpleMemberAccessExpression)
%33 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :35) // Convert.ToInt32(this.numericUpDown1.Text) (InvocationExpression)
%34 = muli %29, %33 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :25)
cbde.store %34, %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :16)
%35 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :20) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%36 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :50) // Globals.listaProdotti (SimpleMemberAccessExpression)
%37 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :72)
%38 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :50) // Globals.listaProdotti[i] (ElementAccessExpression)
%39 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :50) // Globals.listaProdotti[i].getNome() (InvocationExpression)
%40 = cbde.load %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :86)
%41 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :20) // database.verificaQuantitaProd(Globals.listaProdotti[i].getNome(), numero) (InvocationExpression)
%42 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :96)
%43 = cmpi "sgt", %41, %42 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :20)
cond_br %43, ^6, ^7 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :20)

^6: // JumpBlock
// Entity from another assembly: MessageBox
%44 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :86 :36) // "Non hai abbastanza quantita di " (StringLiteralExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%45 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :86 :71) // Globals.listaProdotti (SimpleMemberAccessExpression)
%46 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :86 :93)
%47 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :86 :71) // Globals.listaProdotti[i] (ElementAccessExpression)
%48 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :86 :71) // Globals.listaProdotti[i].getNome() (InvocationExpression)
%49 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :86 :36) // Binary expression on unsupported types "Non hai abbastanza quantita di "+ Globals.listaProdotti[i].getNome()
%50 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :86 :20) // MessageBox.Show("Non hai abbastanza quantita di "+ Globals.listaProdotti[i].getNome()) (InvocationExpression)
%51 = constant 0 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :87 :28) // false
cbde.store %51, %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :87 :20)
br ^3 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :88 :20) // break

^7: // SimpleBlock
%52 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :61)
%53 = constant 1 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :61)
%54 = addi %52, %53 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :61)
cbde.store %54, %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :61)
br ^1

^3: // BinaryBranchBlock
%55 = cbde.load %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :93 :15)
%56 = constant 1 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :93 :22) // true
%57 = cmpi "eq", %55, %56 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :93 :15)
cond_br %57, ^8, ^9 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :93 :15)

^8: // ForInitializerBlock
%58 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :29)
%59 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :25) // j
cbde.store %58, %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :25)
br ^10

^10: // BinaryBranchBlock
%60 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :32)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%61 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :36) // Globals.listaProdotti (SimpleMemberAccessExpression)
%62 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :36) // Globals.listaProdotti.Count (SimpleMemberAccessExpression)
%63 = cmpi "slt", %60, %62 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :32)
cond_br %63, ^11, ^12 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :32)

^11: // BinaryBranchBlock
%64 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :98 :38) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%65 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :98 :68) // Globals.listaProdotti (SimpleMemberAccessExpression)
%66 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :98 :90)
%67 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :98 :68) // Globals.listaProdotti[j] (ElementAccessExpression)
%68 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :98 :68) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%69 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :98 :38) // database.recuperoQuantitaProd(Globals.listaProdotti[j].getNome()) (InvocationExpression)
cbde.store %69, %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :98 :20)
// Entity from another assembly: Convert
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%70 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :57) // Globals.listaProdotti (SimpleMemberAccessExpression)
%71 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :79)
%72 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :57) // Globals.listaProdotti[j] (ElementAccessExpression)
%73 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :57) // Globals.listaProdotti[j].getQuantita() (InvocationExpression)
%74 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :41) // Convert.ToInt32(Globals.listaProdotti[j].getQuantita()) (InvocationExpression)
// Entity from another assembly: Convert
%75 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :115) // this (ThisExpression)
%76 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :115) // this.numericUpDown1 (SimpleMemberAccessExpression)
%77 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :115) // this.numericUpDown1.Text (SimpleMemberAccessExpression)
%78 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :99) // Convert.ToInt32(this.numericUpDown1.Text) (InvocationExpression)
%79 = muli %74, %78 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :41)
cbde.store %79, %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :20)
%80 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :103 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%81 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :103 :56) // Globals.listaProdotti (SimpleMemberAccessExpression)
%82 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :103 :78)
%83 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :103 :56) // Globals.listaProdotti[j] (ElementAccessExpression)
%84 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :103 :56) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%85 = cbde.unknown : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :103 :24) // database.verificaProdListaSpesa(Globals.listaProdotti[j].getNome()) (InvocationExpression)
cond_br %85, ^13, ^14 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :103 :24)

^13: // SimpleBlock
%86 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :24) // Not a variable of known type: database
%87 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :55)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%88 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :75) // Globals.listaProdotti (SimpleMemberAccessExpression)
%89 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :97)
%90 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :75) // Globals.listaProdotti[j] (ElementAccessExpression)
%91 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :75) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%92 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :24) // database.UpdateListaDellaSpesa(quantitaDaTogliere, Globals.listaProdotti[j].getNome()) (InvocationExpression)
br ^15

^14: // SimpleBlock
%93 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :109 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%94 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :109 :50) // Globals.listaProdotti (SimpleMemberAccessExpression)
%95 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :109 :72)
%96 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :109 :50) // Globals.listaProdotti[j] (ElementAccessExpression)
%97 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :109 :50) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%98 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :109 :86)
%99 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :109 :24) // database.InsertListaSpesa(Globals.listaProdotti[j].getNome(), quantitaDaTogliere) (InvocationExpression)
br ^15

^15: // BinaryBranchBlock
%100 = cbde.load %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :112 :24)
%101 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :112 :42)
%102 = subi %100, %101 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :112 :24)
%103 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :112 :64)
%104 = cmpi "eq", %102, %103 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :112 :24)
cond_br %104, ^16, ^17 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :112 :24)

^16: // SimpleBlock
%105 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%106 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :44) // Globals.listaProdotti (SimpleMemberAccessExpression)
%107 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :66)
%108 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :44) // Globals.listaProdotti[j] (ElementAccessExpression)
%109 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :44) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%110 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :24) // database.DeleteProd(Globals.listaProdotti[j].getNome()) (InvocationExpression)
br ^18

^17: // SimpleBlock
%111 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%112 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :44) // Globals.listaProdotti (SimpleMemberAccessExpression)
%113 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :66)
%114 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :44) // Globals.listaProdotti[j] (ElementAccessExpression)
%115 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :44) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%116 = cbde.load %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :80)
%117 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :98)
%118 = subi %116, %117 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :80)
%119 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :118 :24) // database.UpdateProd(Globals.listaProdotti[j].getNome(), quantitaVecchia - quantitaDaTogliere) (InvocationExpression)
br ^18

^18: // SimpleBlock
%120 = cbde.load %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :65)
%121 = constant 1 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :65)
%122 = addi %120, %121 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :65)
cbde.store %122, %59 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :96 :65)
br ^10

^12: // SimpleBlock
// Entity from another assembly: MessageBox
%123 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :123 :32) // "Hai fatto la ricetta" (StringLiteralExpression)
%124 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :123 :16) // MessageBox.Show("Hai fatto la ricetta") (InvocationExpression)
br ^9

^9: // ExitBlock
return

}
