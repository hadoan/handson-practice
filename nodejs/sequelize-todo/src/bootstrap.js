module.exports = async() =>{
    const Tweet = require('./models/Tweet');
    const User = require('./models/User');


    User.hasMany(Tweet,{as: "tweets",foreignKey:"userid"})

    const errHandler = (err)=>{
        console.error("Error: ",err);
    }

    const user = await User.create({username: 'hadoan', password: '123456'}).catch(errHandler);

    const tweet =await Tweet.create({content: 'this is ha tweet',userid: user.id}).catch(errHandler);
    
}