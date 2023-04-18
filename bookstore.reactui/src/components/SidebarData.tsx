import React from 'react'
import * as FaIcons from 'react-icons/fa' 

export const SidebarData = [
    {
        title: 'Home',
        path: '/',
		icon: <FaIcons.FaHome />		
    },
    {
        title: 'Table',
        path: '/table',
        icon: <FaIcons.FaTable />
    },
    {
        title: 'Tasks',
        path: '/tasks',
        icon: <FaIcons.FaTasks />
    },
    {
        title: 'Chats',
        path: '/chats',
        icon: <FaIcons.FaRocketchat />
    },
    {
        title: 'Analytics',
        path: '/analytics',
        icon: <FaIcons.FaRegChartBar />
    }
]
