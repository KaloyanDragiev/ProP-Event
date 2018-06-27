<form action="add.php" method="post">
	<select name="amount" onchange="this.form.submit()">
		<option value="10">10E</option>
		<option value="20">20E</option>
		<option value="50">30E</option>
		<option value="100">40E</option>
	</select>
	
	<button class="add" onclick = "addmoney()">Add Funds</button>
</form>