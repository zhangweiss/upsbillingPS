           //save customer
            string cust_in = ddlCustomer_int.SelectedItem.ToString();
            string cust_db = db.GetCustomer(txtSN.Text);
            if (cust_db == String.Empty)
            {
                if (db.SaveCustomer(cust_in, txtSN.Text))
                {
                    lblerr.Text += "Customer Saved ";
                }
                else
                {
                    lblerr.Text += "Error in saving customer! ";
                }
            }
            else
            {
                if (cust_in != cust_db)
                {
                   // Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>Alert('Customer is already in database!')</script>");
                    lblerr.Text += "Customer is already in database, but we got a conflict!";
                }
                else
                {
                    lblerr.Text += "Customer is already in database!";
                }
               
            }