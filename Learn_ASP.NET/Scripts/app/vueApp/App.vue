<template>
    <div class="container d-flex flex-column justify-content-start">
        <h1 class="display-4 text center view-header">Expense Tracker</h1>
        <Modal v-bind:modalContent="modal.content" v-bind:modalTitle="modal.title"></Modal>
        <div class="row align-items-center">
            <form id="expense-form" @submit.prevent="handleSubmit(inputs.expenseName, inputs.expenseAmount)" class="input-group">
                <input v-model="inputs.expenseName"
                       placeHolder="Enter expense"
                       type="text" class="form-control"
                       aria-label="Name of expense">
                <input v-model="inputs.expenseAmount"
                       placeHolder="Enter amount"
                       type="text"
                       class="form-control"
                       aria-label="Expense amount">
                <div class="input-group-append">
                    <button for="expense-form" class="btn btn-outline-secondary" type="submit">Submit</button>
                </div>
            </form>
            <Table v-bind:expenses="expenses"></Table>
            <button v-on:click="clearTable" class="btn btn-outline-dark">Clear Table</button>
            <router-link to="summary">Expense Summary</router-link>
        </div>
    </div>
</template>
<script>
import Table from "./components/Table.vue";
import Modal from "./components/Modal.vue";

  export default {
    components: {Table, Modal},
    data() {
      return {
        inputs:{
          expenseName: "",
          expenseAmount: ""
        },
        expenses:[
          {
            name: "Coffee",
            amount: "3.50",
          },
          {
            name: "lunch",
            amount: "8.00",
          }
        ],
        modal:{
            title: "Vue.js App",
            content: "This expense tracker is a simple Vue.js app incorporated into an ASP.NET MVC application."
        }
      }
    },
    methods: {
      handleSubmit(name, amount){
        let amountWithTwoDecimals = ((amount * 100) / 100).toFixed(2);

        this.expenses.push({name, amount: amountWithTwoDecimals});

        this.inputs.expenseName = "";
        this.inputs.expenseAmount = "";
      },
      clearTable(){
        this.expenses = [];
      }
    }
  }
</script>
