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
func @_ProgettoBirra.FormRicetta.buttonModificaRic_Click$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :51 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :51 :45)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :51 :45)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :51 :60)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :51 :60)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :53 :12) // Not a variable of known type: database
%3 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :53 :31) // Not a variable of known type: textBoxNome
%4 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :53 :31) // textBoxNome.Text (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :53 :49) // Not a variable of known type: textBoxNote
%6 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :53 :49) // textBoxNote.Text (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :53 :12) // database.UpdateRic(textBoxNome.Text, textBoxNote.Text) (InvocationExpression)
// Entity from another assembly: MessageBox
%8 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :54 :28) // "La nota è stata modificata con successo" (StringLiteralExpression)
%9 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :54 :12) // MessageBox.Show("La nota è stata modificata con successo") (InvocationExpression)
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :12) // this (ThisExpression)
%11 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :57 :12) // this.Close() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_ProgettoBirra.FormRicetta.buttonPrepara$object.System.EventArgs$(none, none) -> () loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :60 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :60 :35)
cbde.store %_sender, %0 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :60 :35)
%1 = cbde.alloca none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :60 :50)
cbde.store %_e, %1 : memref<none> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :60 :50)
br ^0

^0: // ForInitializerBlock
%2 = constant 1 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :62 :25) // true
%3 = cbde.alloca i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :62 :17) // fatta
cbde.store %2, %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :62 :17)
%4 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :63 :16) // numero
%5 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :64 :16) // quantitaDaTogliere
%6 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :65 :16) // quantitaVecchia
%7 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :25)
%8 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :21) // i
cbde.store %7, %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :21)
br ^1

^1: // BinaryBranchBlock
%9 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :28)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%10 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :32) // Globals.listaProdotti (SimpleMemberAccessExpression)
%11 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :32) // Globals.listaProdotti.Count (SimpleMemberAccessExpression)
%12 = cmpi "slt", %9, %11 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :28)
cond_br %12, ^2, ^3 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :28)

^2: // BinaryBranchBlock
%13 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :21) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%14 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :43) // Globals.listaProdotti (SimpleMemberAccessExpression)
%15 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :65)
%16 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :43) // Globals.listaProdotti[i] (ElementAccessExpression)
%17 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :43) // Globals.listaProdotti[i].getNome() (InvocationExpression)
%18 = cbde.unknown : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :21) // database.verificaProd(Globals.listaProdotti[i].getNome()) (InvocationExpression)
%19 = cbde.unknown : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :20) // !database.verificaProd(Globals.listaProdotti[i].getNome()) (LogicalNotExpression)
cond_br %19, ^4, ^5 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :70 :20)

^4: // JumpBlock
// Entity from another assembly: MessageBox
%20 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :36) // "Impossibile preparare ricetta, non hai i prodotti necessari" (StringLiteralExpression)
%21 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :72 :20) // MessageBox.Show("Impossibile preparare ricetta, non hai i prodotti necessari") (InvocationExpression)
%22 = constant 0 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :73 :28) // false
cbde.store %22, %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :73 :20)
br ^3 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :74 :20) // break

^5: // BinaryBranchBlock
// Entity from another assembly: Convert
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%23 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :41) // Globals.listaProdotti (SimpleMemberAccessExpression)
%24 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :63)
%25 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :41) // Globals.listaProdotti[i] (ElementAccessExpression)
%26 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :41) // Globals.listaProdotti[i].getQuantita() (InvocationExpression)
%27 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :25) // Convert.ToInt32(Globals.listaProdotti[i].getQuantita()) (InvocationExpression)
cbde.store %27, %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :77 :16)
%28 = cbde.load %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :25)
// Entity from another assembly: Convert
%29 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :51) // this (ThisExpression)
%30 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :51) // this.numericUpDown1 (SimpleMemberAccessExpression)
%31 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :51) // this.numericUpDown1.Text (SimpleMemberAccessExpression)
%32 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :35) // Convert.ToInt32(this.numericUpDown1.Text) (InvocationExpression)
%33 = muli %28, %32 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :25)
cbde.store %33, %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :78 :16)
%34 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :20) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%35 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :50) // Globals.listaProdotti (SimpleMemberAccessExpression)
%36 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :72)
%37 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :50) // Globals.listaProdotti[i] (ElementAccessExpression)
%38 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :50) // Globals.listaProdotti[i].getNome() (InvocationExpression)
%39 = cbde.load %4 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :86)
%40 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :20) // database.verificaQuantitaProd(Globals.listaProdotti[i].getNome(), numero) (InvocationExpression)
%41 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :96)
%42 = cmpi "sgt", %40, %41 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :20)
cond_br %42, ^6, ^7 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :80 :20)

^6: // JumpBlock
// Entity from another assembly: MessageBox
%43 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :36) // "Non hai abbastanza quantita di " (StringLiteralExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%44 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :71) // Globals.listaProdotti (SimpleMemberAccessExpression)
%45 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :93)
%46 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :71) // Globals.listaProdotti[i] (ElementAccessExpression)
%47 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :71) // Globals.listaProdotti[i].getNome() (InvocationExpression)
%48 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :36) // Binary expression on unsupported types "Non hai abbastanza quantita di "+ Globals.listaProdotti[i].getNome()
%49 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :82 :20) // MessageBox.Show("Non hai abbastanza quantita di "+ Globals.listaProdotti[i].getNome()) (InvocationExpression)
%50 = constant 0 : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :83 :28) // false
cbde.store %50, %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :83 :20)
br ^3 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :84 :20) // break

^7: // SimpleBlock
%51 = cbde.load %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :61)
%52 = constant 1 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :61)
%53 = addi %51, %52 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :61)
cbde.store %53, %8 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :68 :61)
br ^1

^3: // BinaryBranchBlock
%54 = cbde.load %3 : memref<i1> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :89 :15)
cond_br %54, ^8, ^9 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :89 :15)

^8: // ForInitializerBlock
%55 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :29)
%56 = cbde.alloca i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :25) // j
cbde.store %55, %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :25)
br ^10

^10: // BinaryBranchBlock
%57 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :32)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%58 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :36) // Globals.listaProdotti (SimpleMemberAccessExpression)
%59 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :36) // Globals.listaProdotti.Count (SimpleMemberAccessExpression)
%60 = cmpi "slt", %57, %59 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :32)
cond_br %60, ^11, ^12 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :32)

^11: // BinaryBranchBlock
%61 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :94 :38) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%62 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :94 :68) // Globals.listaProdotti (SimpleMemberAccessExpression)
%63 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :94 :90)
%64 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :94 :68) // Globals.listaProdotti[j] (ElementAccessExpression)
%65 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :94 :68) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%66 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :94 :38) // database.recuperoQuantitaProd(Globals.listaProdotti[j].getNome()) (InvocationExpression)
cbde.store %66, %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :94 :20)
// Entity from another assembly: Convert
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%67 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :57) // Globals.listaProdotti (SimpleMemberAccessExpression)
%68 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :79)
%69 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :57) // Globals.listaProdotti[j] (ElementAccessExpression)
%70 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :57) // Globals.listaProdotti[j].getQuantita() (InvocationExpression)
%71 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :41) // Convert.ToInt32(Globals.listaProdotti[j].getQuantita()) (InvocationExpression)
// Entity from another assembly: Convert
%72 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :115) // this (ThisExpression)
%73 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :115) // this.numericUpDown1 (SimpleMemberAccessExpression)
%74 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :115) // this.numericUpDown1.Text (SimpleMemberAccessExpression)
%75 = cbde.unknown : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :99) // Convert.ToInt32(this.numericUpDown1.Text) (InvocationExpression)
%76 = muli %71, %75 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :41)
cbde.store %76, %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :95 :20)
%77 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%78 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :56) // Globals.listaProdotti (SimpleMemberAccessExpression)
%79 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :78)
%80 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :56) // Globals.listaProdotti[j] (ElementAccessExpression)
%81 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :56) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%82 = cbde.unknown : i1 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :24) // database.verificaProdListaSpesa(Globals.listaProdotti[j].getNome()) (InvocationExpression)
cond_br %82, ^13, ^14 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :99 :24)

^13: // SimpleBlock
%83 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :101 :24) // Not a variable of known type: database
%84 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :101 :55)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%85 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :101 :75) // Globals.listaProdotti (SimpleMemberAccessExpression)
%86 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :101 :97)
%87 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :101 :75) // Globals.listaProdotti[j] (ElementAccessExpression)
%88 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :101 :75) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%89 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :101 :24) // database.UpdateListaDellaSpesa(quantitaDaTogliere, Globals.listaProdotti[j].getNome()) (InvocationExpression)
br ^15

^14: // SimpleBlock
%90 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%91 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :50) // Globals.listaProdotti (SimpleMemberAccessExpression)
%92 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :72)
%93 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :50) // Globals.listaProdotti[j] (ElementAccessExpression)
%94 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :50) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%95 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :86)
%96 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :105 :24) // database.InsertListaSpesa(Globals.listaProdotti[j].getNome(), quantitaDaTogliere) (InvocationExpression)
br ^15

^15: // BinaryBranchBlock
%97 = cbde.load %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :108 :24)
%98 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :108 :42)
%99 = subi %97, %98 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :108 :24)
%100 = constant 0 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :108 :64)
%101 = cmpi "eq", %99, %100 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :108 :24)
cond_br %101, ^16, ^17 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :108 :24)

^16: // SimpleBlock
%102 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :110 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%103 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :110 :44) // Globals.listaProdotti (SimpleMemberAccessExpression)
%104 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :110 :66)
%105 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :110 :44) // Globals.listaProdotti[j] (ElementAccessExpression)
%106 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :110 :44) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%107 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :110 :24) // database.DeleteProd(Globals.listaProdotti[j].getNome()) (InvocationExpression)
br ^18

^17: // SimpleBlock
%108 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :24) // Not a variable of known type: database
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Globals
%109 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :44) // Globals.listaProdotti (SimpleMemberAccessExpression)
%110 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :66)
%111 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :44) // Globals.listaProdotti[j] (ElementAccessExpression)
%112 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :44) // Globals.listaProdotti[j].getNome() (InvocationExpression)
%113 = cbde.load %6 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :80)
%114 = cbde.load %5 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :98)
%115 = subi %113, %114 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :80)
%116 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :114 :24) // database.UpdateProd(Globals.listaProdotti[j].getNome(), quantitaVecchia - quantitaDaTogliere) (InvocationExpression)
br ^18

^18: // SimpleBlock
%117 = cbde.load %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :65)
%118 = constant 1 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :65)
%119 = addi %117, %118 : i32 loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :65)
cbde.store %119, %56 : memref<i32> loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :92 :65)
br ^10

^12: // SimpleBlock
// Entity from another assembly: MessageBox
%120 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :119 :32) // "Hai fatto la ricetta" (StringLiteralExpression)
%121 = cbde.unknown : none loc("Z:\\Scuola\\c# git\\progetto-birra-3-gruppo-birra-3\\ProgettoBirra\\ProgettoBirra\\FormRicetta.cs" :119 :16) // MessageBox.Show("Hai fatto la ricetta") (InvocationExpression)
br ^9

^9: // ExitBlock
return

}
