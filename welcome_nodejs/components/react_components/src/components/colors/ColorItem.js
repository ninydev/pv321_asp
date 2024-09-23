export default (props) => {




    return (
        <>
            <img
                src={`http://localhost:5227${props.color.url}`}
                alt={props.color.name}
                width='50px'
                height='50px'
            />
            {props.color.name}
        </>
    )

}