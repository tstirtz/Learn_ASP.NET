<template>
    <div class="table-container">
        <table class="table table-striped table-borderless table-sm">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">Expense</th>
                    <th scope="col">Amount</th>
                </tr>
            </thead>
            <tr v-for="(expense, index) in expenses" v-bind:key="index">
                <td>{{expense.name}}</td>
                <td>$ {{expense.amount}}</td>
            </tr>
            <tr class="total">
                <td>Total</td>
                <td>$ {{ total }}</td>
            </tr>
        </table>
    </div>
</template>
<script>
export default {
    props: {
      expenses: {
        type: Array,
      },
      total: {
        type: String,
      }
    }
  }
</script>
