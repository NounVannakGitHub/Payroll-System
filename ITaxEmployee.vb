Public Interface ITaxEmployee
    Sub Show(dgv As DataGridView)
    Sub Search(taxID As String, dgv As DataGridView)
    Sub Delete(taxID As String)
    Sub Update(taxID As String, tax As TaxEmployee)
    Sub Insert(tax As TaxEmployee)
End Interface
