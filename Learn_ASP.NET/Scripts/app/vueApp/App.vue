<template>
    <div class="container d-flex flex-column justify-content-start">
        <h1 class="display-4 text center view-header">Expense Tracker</h1>
        <Modal v-bind:modalContent="modal.content" v-bind:modalTitle="modal.title"></Modal>
        <div class="row align-items-center">
            <form id="expense-form" @submit.prevent="handleSubmit(inputs.expenseName, inputs.expenseAmount, inputs.expenseCateory)" class="input-group">
                <input v-model="inputs.expenseName"
                       placeHolder="Enter expense"
                       type="text" 
                       class="form-control"
                       aria-label="Name of expense">
                <input v-model="inputs.expenseAmount"
                       placeHolder="Enter amount"
                       type="text"
                       class="form-control"
                       aria-label="Expense amount">
                <select class="custom-select" v-model="inputs.expenseCategory">
                    <option>Category...</option>
                    <option value="groceries">Groceries</option>
                    <option value="coffee">Coffee</option>
                    <option value="restaurants">Restaurants</option>
                    <option value="car">Car</option>
                    <option value="rent">Rent</option>
                    <option value="misc">Misc.</option>
                </select>
                <div class="input-group-append">
                    <button for="expense-form" class="btn btn-outline-secondary" type="submit">Submit</button>
                </div>
            </form>
            <Table ></Table>
            <div class="buttons-container">
                <button v-on:click="clearTable" class="btn btn-outline-dark">Clear Table</button>
                <router-link class="text-white" to="/summary"><button class="btn btn-dark">Expense Summary</button></router-link>
            </div>
        </div>
    </div>
</template>
<script>
import Table from "./components/Table.vue";
import Modal from "./components/Modal.vue";
import store from "./store";

  export default {
    components: {Table, Modal},
    data() {
      return {
        inputs:{
          expenseName: "",
          expenseAmount: "",
          expenseCategory: "Category..."
        },
        modal:{
            title: "Vue.js App",
            content: "This expense tracker is a simple Vue.js app incorporated into an ASP.NET MVC application."
        }
      }
    },
    methods: {
      handleSubmit(name, amount, category){
        let amountWithTwoDecimals = ((amount * 100) / 100).toFixed(2);

        store.data.expenses.push({name, amount: amountWithTwoDecimals, category });

        this.inputs.expenseName = "";
        this.inputs.expenseAmount = "";
        this.inputs.expenseCategory = "Category...";
      },
      clearTable(){
        store.methods.clearTableAction();
      }
  }
 }
</script>
