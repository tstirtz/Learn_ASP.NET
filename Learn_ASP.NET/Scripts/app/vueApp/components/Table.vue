<template>
    <div class="table-container">
        <table class="table table-striped table-borderless table-sm">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">Expense</th>
                    <th scope="col">Amount</th>
                </tr>
            </thead>
            <tr v-for="(expense, index) in storeState.expenses" v-bind:key="index">
                <td>{{expense.name}}</td>
                <td>$ {{expense.amount}}</td>
            </tr>
            <tr class="total">
                <td>Total</td>
                <td>$ {{ total.total() }}</td>
            </tr>
        </table>
    </div>
</template>
<script>
import store from "../store";
export default {
    data(){
        return{
            storeState: store.data,
            total: store.methods
        }
    },
  }
</script>
