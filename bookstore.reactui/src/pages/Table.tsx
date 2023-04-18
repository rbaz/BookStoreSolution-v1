import React from 'react'
import styled from 'styled-components'

const TableText = styled.div`
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 50px;
    height: 70vh;
`

const Table: React.FunctionComponent = () => {
    return (
        <TableText>Table</TableText>
    )
}

export default Table
