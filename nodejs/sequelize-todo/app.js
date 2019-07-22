const express = require('express')
const app = express()
const port = 3000

//Db connection
require("./src/database/connection")

app.get('/',(req,res)=>{
    res.send('hello world')
})

app.listen(port,()=>console.log(`Express listening on port ${port}`))